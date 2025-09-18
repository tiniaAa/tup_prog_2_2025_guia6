using Ejercicio_3.Models;
using System.Xml.Serialization;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {

        List <Persona> personas = new List <Persona> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 formDatos = new Form2();

            formDatos.ShowDialog();
            bool cerrar = false; 
            while (formDatos.DialogResult==DialogResult.OK && cerrar==false)
            {
                string nombre = formDatos.tbNombre.Text;

                Persona personna = null;
                if (formDatos.rdbnFisica.Checked==true)
                {
                    personna = new Persona(nombre);
                }
                else if (formDatos.rdbnJuridica.Checked==true)
                {
                    string cuit = formDatos.tbCUIT.Text;

                    personna = new PersonaJuridica(nombre,cuit);
                }

                if (personna != null)
                {
                    personas.Add(personna);
                    Actualizar();
                    cerrar =true;
                }
                else 
                {
                    
                    MessageBox.Show("seleccione una tipo de persona ");
                    formDatos.ShowDialog();
                }

            }

        }
        private void Actualizar()
        {
            listBox1.Items.Clear();

            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.Describir());
            }
        }
    }
}
