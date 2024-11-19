namespace list_log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            string apellido = textBox2.Text.Trim();
            string tipoUsuario = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, completa ambos campos (Nombre y Apellido).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tipoUsuario) || (tipoUsuario != "Administrador" && tipoUsuario != "Usuario"))
            {
                MessageBox.Show("Selecciona un tipo de usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = $"{nombre} {apellido}";
            if (tipoUsuario == "Administrador")
            {
                listBox1.Items.Add(fullName);
            }
            else if (tipoUsuario == "Usuario")
            {
                listBox2.Items.Add(fullName);
            }

            UpdateCounts();

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCounts()
        {
            int adminCount = listBox1.Items.Count;
            int userCount = listBox2.Items.Count;

            Text = $"Administradores: {adminCount} | Usuarios: {userCount}";
        }
    }
}
