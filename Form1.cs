using System.Text.RegularExpressions;

namespace RegistroDeEstudiantes_ManejoExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try // Uso del try para las validaciones y restricciones
            {

                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
                    throw new Exception("El campo 'Nombre Completo' está vacío.");

                if (string.IsNullOrWhiteSpace(txtEdad.Text))
                    throw new Exception("El campo 'Edad' está vacío.");

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                    throw new Exception("El campo 'Correo Electrónico' está vacío.");


                if (!int.TryParse(txtEdad.Text, out int edad))
                    throw new Exception("La edad debe ser un número entero válido.");

                if (edad <= 0 || edad > 20)
                    throw new Exception("La edad debe estar entre 1 y 20 años.");


                if (!EsCorreoValido(txtCorreo.Text))
                    throw new Exception("El formato del correo electrónico no es válido.\nEjemplo: usuario@gmail.com");


                if (!string.IsNullOrWhiteSpace(txtTelefono?.Text))
                {
                    if (!EsTelefonoValido(txtTelefono.Text))
                        throw new Exception("El formato del teléfono no es válido.\nEjemplo: 809-555-1234");
                }


                MessageBox.Show($"¡Registro exitoso!\n\nNombre: {txtNombreCompleto.Text}\nEdad: {edad} años\nCorreo: {txtCorreo.Text}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) //  Uso del catch para atrapar cualquier error de validación
            {
                MessageBox.Show(ex.Message, "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try // Uso de try para limpiar todos los campos 
            {
                txtNombreCompleto.Clear();
                txtEdad.Clear();
                txtCorreo.Clear();


                if (txtTelefono != null) txtTelefono.Clear();

                txtNombreCompleto.Focus();
            }
            catch (Exception ex) // Uso de catch para atrapar cualquier error al limpiar 
            {
                MessageBox.Show($"Error al limpiar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try // Uso de try para habilitar el botón de salir 
            {
                DialogResult resultado = MessageBox.Show("¿Deseas salir de la aplicación?",
                    "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                    Application.Exit();
            }
            catch (Exception ex) // Uso de catch para cualquier error al cerrar la aplicación
            {
                MessageBox.Show($"Error al salir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(correo, patron);
        }

        private bool EsTelefonoValido(string telefono)
        {
            string telefonoLimpio = telefono.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            string patron = @"^[0-9]{10}$";
            return Regex.IsMatch(telefonoLimpio, patron);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
