using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int contador;
    String opcion;
    float numero1;
    float numero2;
    float contadorigual;
    float result;
    operaciones resultado = new operaciones();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();


        Bvaciar.ModifyBg(StateType.Normal, new Gdk.Color(150, 150, 150));
        BD.ModifyBg(StateType.Normal, new Gdk.Color(112, 141, 242));
        BM.ModifyBg(StateType.Normal, new Gdk.Color(112, 141, 242));
        BR.ModifyBg(StateType.Normal, new Gdk.Color(112, 141, 242));
        BS.ModifyBg(StateType.Normal, new Gdk.Color(112, 141, 242));
        BI.ModifyBg(StateType.Normal, new Gdk.Color(112, 141, 242));
        // color de la pantalla
        ModifyBg(StateType.Normal, new Gdk.Color(8, 8, 8));
   //     label1.ModifyBg(StateType.Normal, new Gdk.Color(231, 231, 231));

        operaciones resultado = new operaciones();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //Boton vaciar
    protected void OnBvaciarClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(0, Pantalla.Text.Length);

    }


    //boton  borrar solo un numero
    protected void OnBCClicked(object sender, EventArgs e)
    {

        Pantalla.DeleteText(Pantalla.Text.Length - 1, Pantalla.Text.Length);
        String display = Pantalla.Text.ToString();
        if (display.Contains("."))
        {
            contador = 0;
        }

    }

    //boton dividir
    protected void OnBDClicked(object sender, EventArgs e)
    {
        numero1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
     //   Pantalla.InsertText(display + " / ");
        opcion = "/";

    }

    //boton multiplicacion
    protected void OnBMClicked(object sender, EventArgs e)
    {
        numero1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
     //   Pantalla.InsertText(display + " * ");
        opcion = "*";
    }

    //boton resta
    protected void OnBRClicked(object sender, EventArgs e)
    {
        numero1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
     //   Pantalla.InsertText(display + " - ");
        opcion = "-";
    }
    //boton suma
    protected void OnBSClicked(object sender, EventArgs e)
    {
        numero1 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
       // Pantalla.InsertText(display + " + ");
        opcion = "+";



    }
    //boton igual
    protected void OnBIClicked(object sender, EventArgs e)
    {


        numero2 = Convert.ToSingle(Pantalla.Text);
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);

        switch (opcion)
        {
            case "+":


                result = resultado.suma(numero1, numero2);
                this.Pantalla.Text = (Convert.ToString(result));
                contadorigual++;
                break;


            case "-":
                result = resultado.resta(numero1, numero2);
                this.Pantalla.Text = (Convert.ToString(result));
                contadorigual++;
                break;



            case "*":
                result = resultado.multiplicacion(numero1, numero2);
                this.Pantalla.Text = (Convert.ToString(result));
                contadorigual++;
                break;


            case "/":
                result = resultado.division(numero1, numero2);
                this.Pantalla.Text = (Convert.ToString(result));
                contadorigual++;
                break;

        }




    }

  
    //boton punto(.)
    protected void OnBPClicked(object sender, EventArgs e)
    {
        if (contador == 0)
        {
            String display = Pantalla.Text.ToString();
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            Pantalla.InsertText(display + " ,");
            contador++;
        }

    }

    //cero
    protected void OnBCeroClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + " 0 ");
    }
    //uno
    protected void OnB1Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "1");
    }
    //dos
    protected void OnB2Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "2");
    }
    //tres
    protected void OnB3Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "3");
    }
    //cuatro
    protected void OnB4Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "4");
    }
    //cinco
    protected void OnB5Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "5");
    }

    protected void OnB6Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "6");
    }

    protected void OnB7Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "7");
    }

    protected void OnB8Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "8");
    }

    protected void OnB9Clicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "9");
    }


}

