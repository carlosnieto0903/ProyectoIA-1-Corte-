using Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo
{
    public class Clase
    {
        private Proyecto.Vista.Inicio vistaInicio;

        public Clase(Inicio vistaInicio)
        {
            this.vistaInicio = vistaInicio;
        }

        public void DesactivarElementos()
        {
            vistaInicio.getT1().Enabled = false;
            vistaInicio.getT2().Enabled = false;
            vistaInicio.getT3().Enabled = false;
            vistaInicio.getT4().Enabled = false;
            vistaInicio.getT5().Enabled = false;
            vistaInicio.getT6().Enabled = false;
            vistaInicio.getT7().Enabled = false;
            vistaInicio.getT8().Enabled = false;
            vistaInicio.getT9().Enabled = false;
            vistaInicio.getT10().Enabled = false;
            vistaInicio.getT11().Enabled = false;
            vistaInicio.getT12().Enabled = false;
            vistaInicio.getT13().Enabled = false;
            vistaInicio.getT14().Enabled = false;
            vistaInicio.getT15().Enabled = false;
            vistaInicio.getT16().Enabled = false;
            vistaInicio.getT17().Enabled = false;
            vistaInicio.getT18().Enabled = false;
            vistaInicio.getT19().Enabled = false;
            vistaInicio.getT20().Enabled = false;
            vistaInicio.getT21().Enabled = false;
            vistaInicio.getT22().Enabled = false;
            vistaInicio.getT23().Enabled = false;
            vistaInicio.getT24().Enabled = false;
            vistaInicio.getT25().Enabled = false;
            vistaInicio.getT26().Enabled = false;
            vistaInicio.getT27().Enabled = false;
            vistaInicio.getT28().Enabled = false;
            vistaInicio.getT29().Enabled = false;
            vistaInicio.getT30().Enabled = false;
            vistaInicio.getT31().Enabled = false;
            vistaInicio.getIterar().Visible = false;
            vistaInicio.getCancelar().Visible = false;
        }
        public void Labels()
        {
            vistaInicio.getlbl1().Text = "Max";
            vistaInicio.getlbl3().Text = "Max";
            vistaInicio.getlbl2().Text = "Min";
            vistaInicio.getlbl4().Text = "Min";
        }
        public void DesactivarElementosIns()
        {
            vistaInicio.getN1().Enabled = false;
            vistaInicio.getN2().Enabled = false;
            vistaInicio.getN3().Enabled = false;
            vistaInicio.getN4().Enabled = false;
            vistaInicio.getN5().Enabled = false;
            vistaInicio.getN6().Enabled = false;
            vistaInicio.getN7().Enabled = false;
            vistaInicio.getN8().Enabled = false;
            vistaInicio.getN9().Enabled = false;
            vistaInicio.getN10().Enabled= false;
            vistaInicio.getN11().Enabled = false;
            vistaInicio.getN12().Enabled = false;
            vistaInicio.getN13().Enabled = false;
            vistaInicio.getN14().Enabled = false;
            vistaInicio.getN15().Enabled = false;
            vistaInicio.getN16().Enabled = false;
        }
        public void comparativaVacia()
        {
            if (vistaInicio.getN1().Text == "")
            {
                vistaInicio.getN1().Text = "0";                
            }
            if (vistaInicio.getN2().Text == "")
            {
                vistaInicio.getN2().Text = "0";
            }
            if (vistaInicio.getN3().Text == "")
            {
                vistaInicio.getN3().Text = "0";
            }
            if (vistaInicio.getN4().Text == "")
            {
                vistaInicio.getN4().Text = "0";
            }
            if (vistaInicio.getN5().Text == "")
            {
                vistaInicio.getN5().Text = "0";
            }
            if (vistaInicio.getN6().Text == "")
            {
                vistaInicio.getN6().Text = "0";
            }
            if (vistaInicio.getN7().Text == "")
            {
                vistaInicio.getN7().Text = "0";
            }
            if (vistaInicio.getN8().Text == "")
            {
                vistaInicio.getN8().Text = "0";
            }
            if (vistaInicio.getN9().Text == "")
            {
                vistaInicio.getN9().Text = "0";
            }
            if (vistaInicio.getN10().Text == "")
            {
                vistaInicio.getN10().Text = "0";
            }
            if (vistaInicio.getN11().Text == "")
            {
                vistaInicio.getN11().Text = "0";
            }
            if (vistaInicio.getN12().Text == "")
            {
                vistaInicio.getN12().Text = "0";
            }
            if (vistaInicio.getN13().Text == "")
            {
                vistaInicio.getN13().Text = "0";
            }
            if (vistaInicio.getN14().Text == "")
            {
                vistaInicio.getN14().Text = "0";
            }
            if (vistaInicio.getN15().Text == "")
            {
                vistaInicio.getN15().Text = "0";
            }
            if (vistaInicio.getN16().Text == "")
            {
                vistaInicio.getN16().Text = "0";
            }
        }
    }
}
