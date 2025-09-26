using Ejercicio_3.Models;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Actualizar()
        {
            listBox1.Items.Clear();

            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.Describir());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form2 formDatos = new Form2();

            formDatos.ShowDialog();
            bool cerrar = false;
            while (formDatos.DialogResult == DialogResult.OK && cerrar == false)
            {
                Persona personna = null;
                try
                {
                    string nombre = formDatos.tbNombre.Text;
                    if (formDatos.rdbnFisica.Checked == true)
                    {
                        formDatos.tbCUIT.Enabled = false;

                        personna = new Persona(nombre);

                    }
                    else if (formDatos.rdbnJuridica.Checked == true)
                    {
                        formDatos.tbCUIT.Enabled = true;
                        string cuit = formDatos.tbCUIT.Text;
                        personna = new PersonaJuridica(nombre, cuit);
                    }
                    if (personna != null)
                    {

                        personas.Add(personna);
                        Actualizar();
                        cerrar = true;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una tipo de persona ");

                    }
                }
                catch (FormatoNombreNoValidoExeprion ex) { formDatos.label2.Text = ex.Message; formDatos.label2.Visible = true;}
                catch (FormatoCUITNoValidoExeption ex) { formDatos.label1.Text = ex.Message; formDatos.label1.Visible = true; }

                if (!cerrar)
                {
                    
                    formDatos.ShowDialog();

                }











            }

        }
        
    }
}
