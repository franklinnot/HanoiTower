using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hanoi
{
    public partial class Hanoi : Form
    {
        private Stack torre1, torre2, torre3;

        public Hanoi()
        {
            InitializeComponent();
            torre1 = new Stack();
            torre2 = new Stack();
            torre3 = new Stack();
            Elementos();
        }

        private void btnMove1_Click(object sender, EventArgs e)
        {
            MoverElemento(1);
        }

        private void btnMove2_Click(object sender, EventArgs e)
        {
            MoverElemento(2);
        }

        private void btnMove3_Click(object sender, EventArgs e)
        {
            MoverElemento(3);

        }

        private void Elementos()
        {
            Random random = new Random();
            int pila = random.Next(1, 4);
            if (pila == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    int num = random.Next(1, 100);
                    torre1.Push(num);
                }
                torre1.Comparar();
                torre1.Mostrar(listBox1);
            }
            else if (pila == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    int num = random.Next(1, 100);
                    torre2.Push(num);
                }
                torre2.Comparar();
                torre2.Mostrar(listBox2);
            }
            else if (pila == 3)
            {
                for (int i = 0; i < 10; i++)
                {
                    int num = random.Next(1, 100);
                    torre3.Push(num);
                }
                torre3.Comparar();
                torre3.Mostrar(listBox3);
            }
        }

        private void MoverElemento(int nTorre)
        {
            if (nTorre == 1)
            {
                string torre = Microsoft.VisualBasic.Interaction.InputBox("Selecciona la torre a la que\n" +
                                                                          "deseas mover tu elemento: 2 o 3:", "Entrada de datos", "");
                try
                {
                    int select = Convert.ToInt32(torre);
                    if (select != 2 && select != 3)
                    {
                        MessageBox.Show("Debe seleccionar entre la torre 2 o 3");
                        return;
                    }
                    if (select == 2)
                    {
                        torre1.ValidarIngreso(torre2, 2, 1);
                        torre2.Mostrar(listBox2);
                        torre1.Mostrar(listBox1);
                    }
                    else if (select == 3)
                    {
                        torre1.ValidarIngreso(torre3, 3, 1);
                        torre3.Mostrar(listBox3);
                        torre1.Mostrar(listBox1);
                    }
                }
                catch
                {
                    MessageBox.Show("Debe seleccionar entre la torre 1 o 2");
                }
            }
            else if (nTorre == 2)
            {
                string torre = Microsoft.VisualBasic.Interaction.InputBox("Selecciona la torre a la que\n" +
                                                                          "deseas mover tu elemento: 1 o 3:", "Entrada de datos", "");
                try
                {
                    int select = Convert.ToInt32(torre);
                    if (select != 1 && select != 3)
                    {
                        MessageBox.Show("Debe seleccionar entre la torre 1 o 3");
                        return;
                    }
                    if (select == 1)
                    {
                        torre2.ValidarIngreso(torre1, 1, 2);
                        torre2.Mostrar(listBox2);
                        torre1.Mostrar(listBox1);
                    }
                    else if (select == 3)
                    {
                        torre2.ValidarIngreso(torre3, 3, 2);
                        torre2.Mostrar(listBox2);
                        torre3.Mostrar(listBox3);
                    }
                }
                catch
                {
                    MessageBox.Show("Debe seleccionar entre la torre 1 o 3");
                }
            }
            else if (nTorre == 3)
            {
                string torre = Microsoft.VisualBasic.Interaction.InputBox("Selecciona la torre a la que\n" +
                                                                          "deseas mover tu elemento: 1 o 2:", "Entrada de datos", "");
                try
                {
                    int select = Convert.ToInt32(torre);
                    if (select != 1 && select != 2)
                    {
                        MessageBox.Show("Debe seleccionar entre la torre 1 o 2");
                        return;
                    }
                    if (select == 1)
                    {
                        torre3.ValidarIngreso(torre1, 1, 3);
                        torre3.Mostrar(listBox3);
                        torre1.Mostrar(listBox1);
                    }
                    else if (select == 2)
                    {
                        torre3.ValidarIngreso(torre2, 2, 3);
                        torre3.Mostrar(listBox3);
                        torre2.Mostrar(listBox2);
                    }
                }
                catch
                {
                    MessageBox.Show("Debe seleccionar entre la torre 1 o 2");
                }
            }
            Ganar();

        }

        public void Ganar()
        {
            if (torre1.Win() == true || torre2.Win() == true || torre3.Win() == true)
            {
                MessageBox.Show("GANASTE! TEN, TE INVITO UN LIMÓN :)");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            torre1.Clear();
            torre2.Clear();
            torre3.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Elementos();
        }
    }
}