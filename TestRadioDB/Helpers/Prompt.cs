using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRadioDB.Helpers
{
    public static class Prompt
    {
        public static bool ShowDialog(string title, string message, string yesButton = "Да", string noButton = "Нет")
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 13, Top = 13, Width = 174, Height = 100, Text = message };
            
            Button yes = new Button() { Text = yesButton, Left = 13, Width = 100, Top = 126, DialogResult = DialogResult.Yes };
            Button no = new Button() { Text = noButton, Left = 174, Width = 100, Top = 126, DialogResult = DialogResult.No };
            yes.Click += (sender, e) => { prompt.Close(); };
            no.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(yes);
            prompt.Controls.Add(no);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = yes;
            prompt.CancelButton = no;

            return prompt.ShowDialog() == DialogResult.Yes;
        }
    }
}
