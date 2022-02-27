using System.Security.Cryptography;
using System.Text;

namespace PassApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                StringBuilder allChars = new StringBuilder();
                StringBuilder pass = new StringBuilder();
                Random random = new Random();

                #region Populating ditionary 
                bool symbols = cpecCharsChb.Checked;
                bool nums = numsChb.Checked;
                bool lowercase = lowercaseChb.Checked;
                bool uppercase = uppercaseLettersChb.Checked;
                decimal passLength = passLengthCmb.Value;
                PopulateDic(dic, symbols, nums, lowercase, uppercase, allChars);
                #endregion

                if (dic.Count > 0)
                {
                    PassGenerating(dic, allChars, pass, random, passLength);
                }
                else
                {
                    MessageBox.Show("You must check atleast one check box!", "Warning", MessageBoxButtons.OK);
                }

                generatedPassTxtBox.Text = pass.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed! Please try again! Error: \\n" + ex.Message, "Warning", MessageBoxButtons.OK);
                throw;
            }
        }

        private static void PassGenerating(Dictionary<string, string> dic, StringBuilder allChars, StringBuilder pass, Random random, decimal passLength)
        {
            foreach (var item in dic)
            {
                pass.Append(item.Value[random.Next(item.Value.Length)]);
            }

            while (pass.Length < passLength)
            {
                pass.Append(allChars[random.Next(allChars.Length)]);
            }
        }

        private static void PopulateDic(Dictionary<string, string> dic, bool symbols, bool nums, bool lowercase, bool uppercase, StringBuilder allChars)
        {
            if (symbols)
            {
                dic.Add("symbols", Constants.specChars.ToString());
                allChars.Append(Constants.specChars.ToString());
            }
            if (nums)
            {
                dic.Add("nums", Constants.nums.ToString());
                allChars.Append(Constants.nums.ToString());
            }
            if (lowercase)
            {
                dic.Add("lowercase", Constants.letters.ToString().ToLower());
                allChars.Append(Constants.letters.ToString().ToLower());
            }
            if (uppercase)
            {
                dic.Add("uppercase", Constants.letters.ToString().ToUpper());
                allChars.Append(Constants.letters.ToString().ToUpper());
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(generatedPassTxtBox.Text))
            {
                EncryptPass(generatedPassTxtBox.Text);
            }
            else
            {
                MessageBox.Show("There is no password generated!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void EncryptPass(string pass)
        {
            try
            {
                saveFileDialog.ShowDialog();
                string savePath = saveFileDialog.FileName + ".txt";

                string encryptedPass = EncrypDecrypt.Encrypt(pass);

                using (FileStream fileStream = new(savePath, FileMode.Create, FileAccess.Write))
                {
                    StreamWriter m_WriterParameter = new StreamWriter(fileStream);
                    m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                    m_WriterParameter.Write(encryptedPass);
                    m_WriterParameter.Flush();
                    m_WriterParameter.Close();
                }

                MessageBox.Show($"The password was encrypted and saved in file {saveFileDialog.FileName}!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, please try again! Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(decryptTxtBox.Text))
            {
                decryptedPassLbl.Text = EncrypDecrypt.Decrypt(decryptTxtBox.Text);
            }
            else
            {
                MessageBox.Show("There is no text in text box!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void copyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(decryptedPassLbl.Text))
            {
                try
                {
                    Clipboard.SetText(decryptedPassLbl.Text);
                    MessageBox.Show("Pass is copied!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong! Please try again!", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("There is no decrypted text!", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}