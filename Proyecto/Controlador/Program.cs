using Proyecto.Modelo;
using Proyecto.Vista;

namespace Proyecto.Controlador
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Inicio vista = new Inicio();
            Clase modelo = new Clase(vista);
            Insertar q= new Insertar();
            //Inicio r= new Inicio();
            String selec = "";
            List<int> valoresInicio = new List<int>();
            int[] comp= new int[2];
            bool sec= true;
            int iteracion = 0, num=0,valor=0 ;

            q.getIniciar().Click += (s, e) => {
                //Muestra
                selec = q.getSele().Text;
                vista.Show();
                //Bloquear Elementos
                modelo.DesactivarElementos();
                if(selec == "Min")
                {
                    modelo.Labels();
                    sec = false;                                      
                }
                
                vista.getIniciar().Click += (s, e) => {
                    modelo.DesactivarElementosIns();
                    vista.getIterar().Visible = true;
                    vista.getCancelar().Visible = true;
                    vista.getIniciar().Visible = false;

                    //Validamos los datos
                    modelo.comparativaVacia();
                    valoresInicio.Add(int.Parse(vista.getN1().Text));
                    valoresInicio.Add(int.Parse(vista.getN2().Text));
                    valoresInicio.Add(int.Parse(vista.getN3().Text));
                    valoresInicio.Add(int.Parse(vista.getN4().Text));
                    valoresInicio.Add(int.Parse(vista.getN5().Text));
                    valoresInicio.Add(int.Parse(vista.getN6().Text));
                    valoresInicio.Add(int.Parse(vista.getN7().Text));
                    valoresInicio.Add(int.Parse(vista.getN8().Text));
                    valoresInicio.Add(int.Parse(vista.getN9().Text));
                    valoresInicio.Add(int.Parse(vista.getN10().Text));
                    valoresInicio.Add(int.Parse(vista.getN11().Text));
                    valoresInicio.Add(int.Parse(vista.getN12().Text));
                    valoresInicio.Add(int.Parse(vista.getN13().Text));
                    valoresInicio.Add(int.Parse(vista.getN14().Text));
                    valoresInicio.Add(int.Parse(vista.getN15().Text));
                    valoresInicio.Add(int.Parse(vista.getN16().Text));
                    for (int i = 0; i < valoresInicio.Count; i++)
                    {
                        if (valoresInicio[i] >= 10)
                        {
                            valoresInicio[i] = 0;
                        }
                    }
                    
                    //Empezamos a Iterar
                    vista.getIterar().Click += (s, e) => {                       
                        iteracion++;
                        if (sec == true)
                        {
                            vista.getT1().Text = valoresInicio[num].ToString();
                            vista.getT2().Text = valoresInicio[num+1].ToString();
                            for (int i = 0; i < 2; i++)
                            {
                                comp[i] = valoresInicio[num];
                                vista.getLista().Items.Add(iteracion + "->" + comp[i] + " =");
                                iteracion++;
                                num++;
                            }
                            for(int j = 0; j < 2; j++)
                            {
                                if (comp[j] >= valor) 
                                { 
                                    vista.getT17().Text = comp[j].ToString();
                                    valor= comp[j];
                                    num++;
                                }                                
                                vista.getLista().Items.Add(iteracion + "->" + valor + " >=");
                                iteracion++;
                                
                            }
                            vista.getT17().Text = valor.ToString();
                            vista.getT25().Text = valor.ToString();
                            vista.getLista().Items.Add(iteracion + "->" + valor + "=");
                            iteracion++;
                            vista.getLista().Items.Add(iteracion + "->" + valor + "<=");
                            valor = 0;
                            sec = false;
                        }
                        else
                        {
                            vista.getT1().Text = valoresInicio[num].ToString();
                            vista.getT2().Text = valoresInicio[num + 1].ToString();
                            for (int i = 0; i < 2; i++)
                            {
                                comp[i] = valoresInicio[num];
                                vista.getLista().Items.Add(iteracion + "->" + comp[i] + " =");
                                iteracion++;
                                num++;
                            }
                            valor = 9;
                            for (int j = 0; j < 2; j++)
                            {                                
                                if (comp[j] <= valor)
                                {
                                    vista.getT17().Text = comp[j].ToString();
                                    valor = comp[j];
                                    num++;
                                }
                                vista.getLista().Items.Add(iteracion + "->" + valor + " <=");
                                iteracion++;

                            }
                            vista.getT17().Text = valor.ToString();
                            vista.getT25().Text = valor.ToString();
                            vista.getLista().Items.Add(iteracion + "->" + valor + "=");
                            iteracion++;
                            vista.getLista().Items.Add(iteracion + "->" + valor + ">=");
                            valor = 0;
                            sec = true;
                        }
                    };
                    
                };
            };
            Application.Run(q);
            
        }
    }
}