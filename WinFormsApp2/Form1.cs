namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayResume();
        }

        private void displayResume()
        {
            var resumeParts = new string[]
            {
                "Name: Lisa Buha",
                "Age: 14",
                "Experience: there is no",
                "Skills: C++, C#, Drums play",
                "Education: Lyceum ¹2, IT Academy 'Step', School of Music"
            };

            int charactersAmount = resumeParts.Sum(part => part.Length);

            for (int i = 0; i < resumeParts.Length; i++)
            {
                if (i == resumeParts.Length - 1)
                {
                    MessageBox.Show($"{resumeParts[i]}", $"Average characters per page: {(double)charactersAmount / resumeParts.Length}");
                }
                else
                {
                    string title = $"Part {i + 1} of {resumeParts.Length}";
                    MessageBox.Show(resumeParts[i], title);
                }
            }
        }
    }
}
