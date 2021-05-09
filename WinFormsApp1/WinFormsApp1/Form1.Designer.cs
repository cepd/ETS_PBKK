
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		partial class Form1
		{
			private System.ComponentModel.IContainer components = null;

			int cost = 0;
			int tot = 0;
			int i = 0, result = 0;

			private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
			{

			}

			private void button1_Click(object sender, EventArgs e)
			{
				listBox2.Items.Add(numericUpDown1.Text);

				int cost = 0;

				if (listBox1.SelectedItem == "Hoppers")
				{
					cost = int.Parse(numericUpDown1.Text) = 10;
					listBox3.Items.Add(cost);
				}
				else if (listBox1.SelectedItem = "Shorties")
				{
					cost = Convert.ToInt32(numericUpDown1.Text) = 20;
					listBox3.Items.Add(cost);
				}
				else if (listBox1.SelectedItem = "Rice")
				{
					cost = Convert.ToInt32(numericUpDown1.Text) = 150;
					listBox3.Items.Add(cost);
				}
				else if (listBox1.SelectedItem = "friedrice")
				{
					cost = Convert.ToInt32(numericUpDown1.Text) = 250;
					listBox3.Items.Add(cost);
				}
				else
				{
					MessageBox.Show("Please select the item", "Error", MessageBoxButtons.OK, MessageIcon.Error);

				}
			}
		}
		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

