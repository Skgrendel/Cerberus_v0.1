using Control.Cache;
using Negocio.Funciones_estudiantes;
using System.Drawing.Drawing2D;


namespace Presentacion.Mod_Administrador
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
            RoundCorners(panel1, 10);
            RoundCorners(panel2, 10);
            RoundCorners(panel3, 10);
            RoundCorners(panel4, 10);
            fnt_conteo();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            fnt_conteo();

        }
        public void fnt_conteo()
        {
            Cls_cargar_box oConteo = new Cls_cargar_box();
            oConteo.fntConteo();
            Cls_Cache.str_conteo = oConteo.getConteo();
            lbl_registros.Text = Cls_Cache.str_conteo;

        }
        private void RoundCorners(Panel panel, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = radius * 2;

            // Crea una región elíptica para definir los bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Esquina superior izquierda
            path.AddArc(bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90); // Esquina superior derecha
            path.AddArc(bounds.Width - diameter, bounds.Height - diameter, diameter, diameter, 0, 90); // Esquina inferior derecha
            path.AddArc(bounds.X, bounds.Height - diameter, diameter, diameter, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asigna la región al panel
            panel.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnt_conteo();
        }
    }
}
