using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MeinProjekt
{
    public partial class Form1 : Form
    {
        public List<Fahrzeug> fahrzeug = new List<Fahrzeug>();


        double tmpSteuer; //ein temporäres Objekt welches die Steuerschuld beinhaltet

        public Form1()
        {
            InitializeComponent();
            Fahrzeugliste.DisplayMember = "Kennzeichen"; //Der Name in der Fahrzeugliste ist das Kennzeichen des Objektes
            this.tableLayoutPanel2.Visible = false;//Setzt mein Panel auf invisible 
        } //Mein Tablelayoutpanel wird auf invisible gestellt und der Name des Objektes wird als sein Kennzeichen angezeigt 


        public void Hinzufügen_Click(object sender, EventArgs e)
        {


            using (Form2 hinzufügen = new Form2())//Ich erzeuge mir hiermit zugriff auf Form2
            {


               hinzufügen.ShowDialog();//Kann auf die Werte meiner Hinzufügen liste zugreifen


              
                
                if(hinzufügen.FahrzeugTyp == "PKW")//Prüft was für ein Typ das Objekt ist
                {
 
                    fahrzeug.Add(new PKWs());//Das Fahrzeug das ich hinzufüge soll ein Pkw sein
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "PKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen.ToUpper();
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).PKWMarke = hinzufügen.PKWMarke;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).Leistung = hinzufügen.Leistung;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).PHubraum = hinzufügen.Hubraum;
                    (fahrzeug[fahrzeug.Count - 1] as PKWs).Schadstoffklasse = hinzufügen.Schadstoffklasse;
                    //Credit gehen an Mikail und Lars da sie mir beim Hinzufügen geholfen haben

                }//Wenn es ein PKW ist wird dies Durchgeführt 
                else if(hinzufügen.FahrzeugTyp == "LKW")//Prüft was für ein Typ das Objekt ist
                {
                    fahrzeug.Add(new LKWs());//Das Fahrzeug das ich hinzufüge soll ein Lkw sein
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "LKW";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen.ToUpper();
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    (fahrzeug[fahrzeug.Count - 1] as LKWs).LKWMarke  = hinzufügen.LKWMarke;
                    (fahrzeug[fahrzeug.Count - 1] as LKWs).Anzahl_Der_Achsen = hinzufügen.Anzahl_Der_Achsen;
                    (fahrzeug[fahrzeug.Count - 1] as LKWs).Zuladung = hinzufügen.Zuladung;
                    //Credit gehen an Mikail und Lars da sie mir beim Hinzufügen geholfen haben


                }//Ansonsten wenn es ein LKW ist wird dies durchgeführt
                else if (hinzufügen.FahrzeugTyp == "Motorrad")//Prüft was für ein Typ das Objekt ist
                {
                    fahrzeug.Add(new Motorräder());//Das Fahrzeug das ich hinzufüge soll ein Motorrad sein
                    fahrzeug[fahrzeug.Count - 1].FahrzeugTyp = "Motorrad";
                    fahrzeug[fahrzeug.Count - 1].Modell = hinzufügen.Modell;
                    fahrzeug[fahrzeug.Count - 1].Kennzeichen = hinzufügen.Kennzeichen.ToUpper();
                    fahrzeug[fahrzeug.Count - 1].Jahr_Der_Erstzulassung = hinzufügen.Jahr_Der_Erstzulassung;
                    fahrzeug[fahrzeug.Count - 1].Preis = hinzufügen.Preis;
                    (fahrzeug[fahrzeug.Count - 1] as Motorräder).MotoMarke = hinzufügen.MotoMarke;
                    (fahrzeug[fahrzeug.Count - 1] as Motorräder).Hubraum = hinzufügen.Hubraum;
                    //Credit gehen an Mikail und Lars da sie mir beim Hinzufügen geholfen haben
                }//oder wenn es ein Motorrad ist wird dies ausgeführt
                Fahrzeugliste.Items.Add(fahrzeug[fahrzeug.Count -1]);//Fügt das Erstellte Objekt in die Liste hinzu
                //Speichern(); 
                //Laden();
            }

        } //Diese methode ist dafür da, ein Fahrzeug hinzuzufügen indem ich eine neue Form öffne 


        private void Lösch_Click(object sender, EventArgs e)
        {
            if (Fahrzeugliste.SelectedIndex != -1)//Falls es einen wert in der Fahrzeugliste gibt
            {
                Fahrzeugliste.Items.RemoveAt(Fahrzeugliste.SelectedIndex);//Löscht er das ausgewählte Objet/item
                
                TextLöschen();
            }
        } // wird zum Löschen aus der Liste verwendet

        //Speicher und Lad funktion die nicht Funktioniert,Credit für die Idee geht an Fynn und Arthur
        private void Speichern()
        {
            try
            {
                FileStream stream;
                stream = new FileStream("FahrzeugChronik.ect", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, fahrzeug);
                stream.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Laden()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream;
                stream = new FileStream("FahrzeugChronik.ect", FileMode.Open);
                fahrzeug = (List<Fahrzeug>)formatter.Deserialize(stream);
                stream.Close();

                foreach (Fahrzeug fahrzeug in fahrzeug)
                {
                    //FahrzeugBindingSource.Add(fahrzeug);
                }
            }
            catch(IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Fahrzeugliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            if (Convert.ToString(Fahrzeugliste.SelectedItem) == "K-GS-01")
            {
                Zurücksetzen();
                comboBoxFahrzeugtyp.Text = "PKW";
                tableLayoutPanel2.Controls.Remove(Zuladunglbl);//Löscht das Label für die Zuladung
                tableLayoutPanel2.Controls.Remove(Achsenlbl);//Löscht das Label für die Achsen_Anzahl
                tableLayoutPanel2.Controls.Remove(ZuladungText);//Löscht die Textbox für die Zuladung 
                tableLayoutPanel2.Controls.Remove(AchsenText);//Löscht die Textbox für die Achsen_Anzahl
                tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);//Fügt bei 0,6 das Label für den Hubraum hinzu
                tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 7);//Fügt bei 0,7 das Label für die Leistung hinzu
                tableLayoutPanel2.Controls.Add(Klasselbl, 0, 8);//Fügt bei 0,8 das Label für die Schadstoffklasse hinzu
                tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);//Fügt bei 1,6 die Textbox für den Hubraum hinzu
                tableLayoutPanel2.Controls.Add(LeistungText, 1, 7);//Fügt bei 1,7 die Textbox für die Leistung hinzu
                tableLayoutPanel2.Controls.Add(klassecombo, 1, 8);//Fügt bei 1,8 die Combobox für die Schadstoffklasse hinzu
                tableLayoutPanel2.Controls.Remove(SteuerschuldText);//Fügt bei 1,9 die Textbox für die Schulden hinzu
                tableLayoutPanel2.Controls.Remove(steuerschuldlbl);//Fügt bei 0,9 das Label für die steuerschuld hinzu

                HerstellerText.Text = "VW";
                ModellText.Text = "Käfer";
                maskedkenn.Text = "K-GSO-01";
                Jahrcombo.Text = "1965";
                PreisText.Text = "9999";
                HubraumText.Text = "1000";
                LeistungText.Text = "30";
                klassecombo.Text = "1";
                SteuerschuldText.Text = HubraumText.Text + 99 / 100 * 10 * (Convert.ToDouble(klassecombo.Text) + 1);
            }
            else if (Convert.ToString(Fahrzeugliste.SelectedItem) == "K-GS-02")
            {
                Zurücksetzen();
                comboBoxFahrzeugtyp.Text = "PKW";
                tableLayoutPanel2.Controls.Remove(Zuladunglbl);//Löscht das Label für die Zuladung
                tableLayoutPanel2.Controls.Remove(Achsenlbl);//Löscht das Label für die Achsen_Anzahl
                tableLayoutPanel2.Controls.Remove(ZuladungText);//Löscht die Textbox für die Zuladung 
                tableLayoutPanel2.Controls.Remove(AchsenText);//Löscht die Textbox für die Achsen_Anzahl
                tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);//Fügt bei 0,6 das Label für den Hubraum hinzu
                tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 7);//Fügt bei 0,7 das Label für die Leistung hinzu
                tableLayoutPanel2.Controls.Add(Klasselbl, 0, 8);//Fügt bei 0,8 das Label für die Schadstoffklasse hinzu
                tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);//Fügt bei 1,6 die Textbox für den Hubraum hinzu
                tableLayoutPanel2.Controls.Add(LeistungText, 1, 7);//Fügt bei 1,7 die Textbox für die Leistung hinzu
                tableLayoutPanel2.Controls.Add(klassecombo, 1, 8);//Fügt bei 1,8 die Combobox für die Schadstoffklasse hinzu
                tableLayoutPanel2.Controls.Remove(SteuerschuldText);//Fügt bei 1,9 die Textbox für die Schulden hinzu
                tableLayoutPanel2.Controls.Remove(steuerschuldlbl);//Fügt bei 0,9 das Label für die steuerschuld hinzu

                HerstellerText.Text = "Opel";
                ModellText.Text = "Kadett";
                maskedkenn.Text = "K-GS-02";
                Jahrcombo.Text = "1964";
                PreisText.Text = "12000";
                HubraumText.Text = "1600";
                LeistungText.Text = "60";
                klassecombo.Text = "2";
              
            
            }
            else if(Convert.ToString(Fahrzeugliste.SelectedItem)== "K-GS-04")
            {
                Zurücksetzen();
                comboBoxFahrzeugtyp.Text = "LKW";
                tableLayoutPanel2.Controls.Remove(Klasselbl);//Löscht das Label für die Schadstoffklasse
                tableLayoutPanel2.Controls.Remove(klassecombo);//Läscht die Combobox für die Schastoffklasse
                tableLayoutPanel2.Controls.Remove(Leistunglbl);//Löscht das Label für die Leistung
                tableLayoutPanel2.Controls.Remove(LeistungText);//Löscht die Textbox für die Leistung
                tableLayoutPanel2.Controls.Remove(Hubraumlbl);//Löscht das Label für die Hubraum
                tableLayoutPanel2.Controls.Remove(HubraumText);//Löscht die Textbox für die Hubraum
                tableLayoutPanel2.Controls.Remove(SteuerschuldText);//Fügt bei 1,8 die Textbox für die Schulden hinzu
                tableLayoutPanel2.Controls.Remove(steuerschuldlbl);//Fügt bei 0,8 das Label für die steuerschuld hinzu
                HerstellerText.Text = "Mercedes";
                ModellText.Text = "LG-315";
                maskedkenn.Text = "K-GS-03";
                Jahrcombo.Text = "1960";
                PreisText.Text = "23000";
                AchsenText.Text = "2";
                ZuladungText.Text = "5,5";
             
            }
            else if(Convert.ToString(Fahrzeugliste.SelectedItem) == "K-GS-03")
            {
                Zurücksetzen();
                tableLayoutPanel2.Controls.Remove(Klasselbl);//Löscht das Label für die Schadstoffklasse
                tableLayoutPanel2.Controls.Remove(klassecombo);//Läscht die Combobox für die Schastoffklasse
                tableLayoutPanel2.Controls.Remove(Leistunglbl);//Löscht das Label für die Leistung
                tableLayoutPanel2.Controls.Remove(LeistungText);//Löscht die Textbox für die Leistung
                tableLayoutPanel2.Controls.Remove(Zuladunglbl);//Löscht das Label für die Zuladung
                tableLayoutPanel2.Controls.Remove(ZuladungText);//Löscht die Textbox für die Zuladung 
                tableLayoutPanel2.Controls.Remove(Achsenlbl);//Löscht das Label für die Achsen_Anzahl
                tableLayoutPanel2.Controls.Remove(AchsenText);//Löscht die Textbox für die Achsen_Anzahl
                tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);//Fügt bei 0,6 das Label für den Hubraum hinzu
                tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);//Fügt bei 1,6 die Textbox für den Hubraum hinzu
                tableLayoutPanel2.Controls.Remove(SteuerschuldText);//Fügt bei 1,7 die Textbox für die Steuerschuld hinzu
                tableLayoutPanel2.Controls.Remove(steuerschuldlbl);//Fügt bei 0,7 das Label für die Steuerschuld hinzu 
                comboBoxFahrzeugtyp.Text = "Motorrad";
                HerstellerText.Text = "BMW";
                ModellText.Text = "R-1200-r";
                maskedkenn.Text = "K-GS-03";
                Jahrcombo.Text = "1999";
                PreisText.Text = "6000";
                HubraumText.Text = "1170";
            }
        } //Hier sind die Standardwerte die die 4 Fahrzeuge haben sollen, die man schon beim Laden des Projektes vorhanden haben sollte

    

        private void Fahrzeugliste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            if (Fahrzeugliste.SelectedItem != null)//Falls es ein Objekt in der Liste gibt
            {
                Fahrzeug fahrzeug = Fahrzeugliste.SelectedItem as Fahrzeug;//dann ist das ausgewählte Objekt ein Fahrzeug

                comboBoxFahrzeugtyp.Text = fahrzeug.FahrzeugTyp;//Was in Form 2.ComboFahrzeugtyp steht ist der Wert für die Eigenschaft Fahrzeugtyp in der Liste fahrzeug
                ModellText.Text = fahrzeug.Modell;//Was in Form 2.ModellText steht ist der Wert für die Eigenschaft Modell in der Liste fahrzeug
                maskedkenn.Text = fahrzeug.Kennzeichen;//Was in Form 2.maskedkenn steht ist der Wert für die Eigenschaft Kennzeichen in der Liste fahrzeug
                Jahrcombo.Text = fahrzeug.Jahr_Der_Erstzulassung;//Was in Form 2.Jahrcombo steht ist der Wert für die Eigenschaft Jahr_Der_Erstzulassung in der Liste fahrzeug
                PreisText.Text = fahrzeug.Preis;//Was in Form 2.PreisText steht ist der Wert für die Eigenschaft Preis in der Liste fahrzeug

                if (fahrzeug is PKWs)
                {
                    Zurücksetzen();//Hier bringe ich die Form auf 0
                    tableLayoutPanel2.Controls.Remove(Zuladunglbl);//Löscht das Label für die Zuladung
                    tableLayoutPanel2.Controls.Remove(Achsenlbl);//Löscht das Label für die Achsen_Anzahl
                    tableLayoutPanel2.Controls.Remove(ZuladungText);//Löscht die Textbox für die Zuladung 
                    tableLayoutPanel2.Controls.Remove(AchsenText);//Löscht die Textbox für die Achsen_Anzahl
                    tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);//Fügt bei 0,6 das Label für den Hubraum hinzu
                    tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 7);//Fügt bei 0,7 das Label für die Leistung hinzu
                    tableLayoutPanel2.Controls.Add(Klasselbl, 0, 8);//Fügt bei 0,8 das Label für die Schadstoffklasse hinzu
                    tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);//Fügt bei 1,6 die Textbox für den Hubraum hinzu
                    tableLayoutPanel2.Controls.Add(LeistungText, 1, 7);//Fügt bei 1,7 die Textbox für die Leistung hinzu
                    tableLayoutPanel2.Controls.Add(klassecombo, 1, 8);//Fügt bei 1,8 die Combobox für die Schadstoffklasse hinzu
                    tableLayoutPanel2.Controls.Add(SteuerschuldText, 1, 9);//Fügt bei 1,9 die Textbox für die Schulden hinzu
                    tableLayoutPanel2.Controls.Add(steuerschuldlbl,  0, 9);//Fügt bei 0,9 das Label für die steuerschuld hinzu

                    HubraumText.Text = ((PKWs)fahrzeug).PHubraum;//Castet die Klasse PKWs so das ich auf die Eigenschaften zugreifen kann
                    klassecombo.Text = ((PKWs)fahrzeug).Schadstoffklasse;//Castet die Klasse PKWs so das ich auf die Eigenschaften zugreifen kann
                    LeistungText.Text = ((PKWs)fahrzeug).Leistung;//Castet die Klasse PKWs so das ich auf die Eigenschaften zugreifen kann
                    HerstellerText.Text = ((PKWs)fahrzeug).PKWMarke;//Castet die Klasse PKWs so das ich auf die Eigenschaften zugreifen kann
                    SteuerschuldText.Text = Convert.ToString(((PKWs)fahrzeug).Steuerschuld);//Castet die Klasse PKWs so das ich auf die Eigenschaften zugreifen kann

                }
                else if(fahrzeug is LKWs)
                {
                    Zurücksetzen();//Hier bringe ich die Form auf 0
                    tableLayoutPanel2.Controls.Remove(Klasselbl);//Löscht das Label für die Schadstoffklasse
                    tableLayoutPanel2.Controls.Remove(klassecombo);//Läscht die Combobox für die Schastoffklasse
                    tableLayoutPanel2.Controls.Remove(Leistunglbl);//Löscht das Label für die Leistung
                    tableLayoutPanel2.Controls.Remove(LeistungText);//Löscht die Textbox für die Leistung
                    tableLayoutPanel2.Controls.Remove(Hubraumlbl);//Löscht das Label für die Hubraum
                    tableLayoutPanel2.Controls.Remove(HubraumText);//Löscht die Textbox für die Hubraum
                    tableLayoutPanel2.Controls.Add(SteuerschuldText, 1, 8);//Fügt bei 1,8 die Textbox für die Schulden hinzu
                    tableLayoutPanel2.Controls.Add(steuerschuldlbl, 0, 8);//Fügt bei 0,8 das Label für die steuerschuld hinzu

                    AchsenText.Text = ((LKWs)fahrzeug).Anzahl_Der_Achsen;//Castet die Klasse LKWs so das ich auf die Eigenschaften zugreifen kann
                    ZuladungText.Text = ((LKWs)fahrzeug).Zuladung;//Castet die Klasse LKWs so das ich auf die Eigenschaften zugreifen kann
                    HerstellerText.Text = ((LKWs)fahrzeug).LKWMarke;//Castet die Klasse LKWs so das ich auf die Eigenschaften zugreifen kann
                    SteuerschuldText.Text = Convert.ToString(((LKWs)fahrzeug).Steuerschuld);//Castet die Klasse LKWs so das ich auf die Eigenschaften zugreifen kann

                }
                else if(fahrzeug is Motorräder)
                {
                    Zurücksetzen();//Hier bringe ich die Form auf 0
                    tableLayoutPanel2.Controls.Remove(Klasselbl);//Löscht das Label für die Schadstoffklasse
                    tableLayoutPanel2.Controls.Remove(klassecombo);//Läscht die Combobox für die Schastoffklasse
                    tableLayoutPanel2.Controls.Remove(Leistunglbl);//Löscht das Label für die Leistung
                    tableLayoutPanel2.Controls.Remove(LeistungText);//Löscht die Textbox für die Leistung
                    tableLayoutPanel2.Controls.Remove(Zuladunglbl);//Löscht das Label für die Zuladung
                    tableLayoutPanel2.Controls.Remove(ZuladungText);//Löscht die Textbox für die Zuladung 
                    tableLayoutPanel2.Controls.Remove(Achsenlbl);//Löscht das Label für die Achsen_Anzahl
                    tableLayoutPanel2.Controls.Remove(AchsenText);//Löscht die Textbox für die Achsen_Anzahl
                    tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);//Fügt bei 0,6 das Label für den Hubraum hinzu
                    tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);//Fügt bei 1,6 die Textbox für den Hubraum hinzu
                    tableLayoutPanel2.Controls.Add(SteuerschuldText, 1, 7);//Fügt bei 1,7 die Textbox für die Steuerschuld hinzu
                    tableLayoutPanel2.Controls.Add(steuerschuldlbl, 0, 7);//Fügt bei 0,7 das Label für die Steuerschuld hinzu 

                    HubraumText.Text = ((Motorräder)fahrzeug).Hubraum;//Castet die Klasse Motorräder damit ich auf ihre Eigenschaften zugreifen kann
                    HerstellerText.Text = ((Motorräder)fahrzeug).MotoMarke;//Castet die Klasse Motorräder damit ich auf ihre Eigenschaften zugreifen kann
                    SteuerschuldText.Text = Convert.ToString(((Motorräder)fahrzeug).Steuerschuld);//Castet die Klasse Motorräder damit ich auf ihre Eigenschaften zugreifen kann
                }

            }


        } //Die Methode ist dafür da um das Objekt in der Fahrzeugliste auszugeben wenn man es zweimal anklickt 

        private void Zurücksetzen() //Diese Methode wird verwendet um die Form auf 0 zu bringen
        {
            //Hier werden die Labels als erstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel2.Controls.Add(Typlbl7, 0, 0);
            tableLayoutPanel2.Controls.Add(Herstellerlbl, 0, 1);
            tableLayoutPanel2.Controls.Add(Modelllbl, 0, 2);
            tableLayoutPanel2.Controls.Add(Kennzeichenlbl, 0, 3);
            tableLayoutPanel2.Controls.Add(Jahrlbl, 0, 4);
            tableLayoutPanel2.Controls.Add(Preislbl, 0, 5);
            tableLayoutPanel2.Controls.Add(Achsenlbl, 0, 6);
            tableLayoutPanel2.Controls.Add(Zuladunglbl, 0, 7);
            tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 8);
            tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 9);
            tableLayoutPanel2.Controls.Add(Klasselbl, 0, 10);
            //Hier werden die Textboxen und ComboBoxen als nächstes auf ihre 
            //ursprüngliche Position gebracht
            tableLayoutPanel2.Controls.Add(comboBoxFahrzeugtyp, 1, 0);
            tableLayoutPanel2.Controls.Add(HerstellerText, 1, 1);
            tableLayoutPanel2.Controls.Add(ModellText, 1, 2);
            tableLayoutPanel2.Controls.Add(maskedkenn, 1, 3);
            tableLayoutPanel2.Controls.Add(Jahrcombo, 1, 4);
            tableLayoutPanel2.Controls.Add(PreisText, 1, 5);
            tableLayoutPanel2.Controls.Add(AchsenText, 1, 6);
            tableLayoutPanel2.Controls.Add(ZuladungText, 1, 7);
            tableLayoutPanel2.Controls.Add(LeistungText, 1, 8);
            tableLayoutPanel2.Controls.Add(HubraumText, 1, 9);
            tableLayoutPanel2.Controls.Add(klassecombo, 1, 10);


        }


        private void GesShuldenbtn_Click(object sender, EventArgs e)
        {
            foreach (Fahrzeug fahrzeug in fahrzeug)//fÜR Jedes Fahrzeug in der Liste fahrzeug
            {
                tmpSteuer += fahrzeug.Steuerschuld; //sollen hier die Steuern addiert werden
            }
            MessageBox.Show(tmpSteuer.ToString(), "Steuerschuld für Alle Fahrzeuge", MessageBoxButtons.OK, MessageBoxIcon.Information);//und werden dann hiermit angezeigt

        } //Methode um die Gesamtschulden auszurechnen


        private void Suchenbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;//Das Table soll angezeigt werden
            Fahrzeugliste.SelectedIndex = Fahrzeugliste.FindString(SuchMask.Text);//Er soll das Finden was ich in der Suchmask eingebe
            if (Fahrzeugliste.SelectedIndex != -1)
            {
                Fahrzeug fahrzeug = Fahrzeugliste.SelectedItem as Fahrzeug;
                //Gebe hiermit die 5 standard werte aus sobald das richtige Fahrzeug gefunden wurde
                comboBoxFahrzeugtyp.Text = fahrzeug.FahrzeugTyp;
                ModellText.Text = fahrzeug.Modell;
                maskedkenn.Text = fahrzeug.Kennzeichen;
                Jahrcombo.Text = fahrzeug.Jahr_Der_Erstzulassung;
                PreisText.Text = fahrzeug.Preis;

                if(fahrzeug is LKWs)
                {
                    Zurücksetzen();//Hier bringe ich die Form auf 0
                    //Ich Lösche Textboxén und Label, da LKW nicht die selben Eingeschaften besitzt wie PKW und Motorrad
                    tableLayoutPanel2.Controls.Remove(Klasselbl);
                    tableLayoutPanel2.Controls.Remove(klassecombo);
                    tableLayoutPanel2.Controls.Remove(Leistunglbl);
                    tableLayoutPanel2.Controls.Remove(LeistungText);
                    tableLayoutPanel2.Controls.Remove(Hubraumlbl);
                    tableLayoutPanel2.Controls.Remove(HubraumText);
                    tableLayoutPanel2.Controls.Add(SteuerschuldText, 1, 8);
                    tableLayoutPanel2.Controls.Add(steuerschuldlbl, 0, 8);
                    //Hiermit lass ich die Werte sofort ausgeben wenn das gesuchte Kennzeichen gefunden wurde
                    AchsenText.Text = ((LKWs)fahrzeug).Anzahl_Der_Achsen;
                    ZuladungText.Text = ((LKWs)fahrzeug).Zuladung;
                    HerstellerText.Text = ((LKWs)fahrzeug).LKWMarke;
                    SteuerschuldText.Text = Convert.ToString(((LKWs)fahrzeug).Steuerschuld);

                }
                else if(fahrzeug is PKWs)
                {
                    Zurücksetzen();//Hier bringe ich die Form auf 0
                    //Ich Lösche Textboxen und Label, da PKW nicht die selben Eingeschaften besitzt wie Motorrad und LKW
                    tableLayoutPanel2.Controls.Remove(Zuladunglbl);
                    tableLayoutPanel2.Controls.Remove(Achsenlbl);
                    tableLayoutPanel2.Controls.Remove(ZuladungText);
                    tableLayoutPanel2.Controls.Remove(AchsenText);
                    tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);
                    tableLayoutPanel2.Controls.Add(Leistunglbl, 0, 7);
                    tableLayoutPanel2.Controls.Add(Klasselbl, 0, 8);
                    tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);
                    tableLayoutPanel2.Controls.Add(LeistungText, 1, 7);
                    tableLayoutPanel2.Controls.Add(klassecombo, 1, 8);
                    tableLayoutPanel2.Controls.Add(SteuerschuldText, 1, 9);
                    tableLayoutPanel2.Controls.Add(steuerschuldlbl, 0, 9);
                    //Hiermit lass ich die Werte sofort ausgeben wenn das gesuchte Kennzeichen gefunden wurde
                    HubraumText.Text = ((PKWs)fahrzeug).PHubraum;
                    klassecombo.Text = ((PKWs)fahrzeug).Schadstoffklasse;
                    LeistungText.Text = ((PKWs)fahrzeug).Leistung;
                    HerstellerText.Text = ((PKWs)fahrzeug).PKWMarke;
                    SteuerschuldText.Text = Convert.ToString(((PKWs)fahrzeug).Steuerschuld);
                }
                else if(fahrzeug is Motorräder)
                {
                    Zurücksetzen();//Hier bringe ich die Form auf 0
                    //Ich Lösche Textboxén und Label, da Motorrad nicht die selben Eingeschaften besitzt wie LKW und PKW
                    tableLayoutPanel2.Controls.Remove(Klasselbl);
                    tableLayoutPanel2.Controls.Remove(klassecombo);
                    tableLayoutPanel2.Controls.Remove(Leistunglbl);
                    tableLayoutPanel2.Controls.Remove(LeistungText);
                    tableLayoutPanel2.Controls.Remove(Zuladunglbl);
                    tableLayoutPanel2.Controls.Remove(ZuladungText);
                    tableLayoutPanel2.Controls.Remove(Achsenlbl);
                    tableLayoutPanel2.Controls.Remove(AchsenText);
                    tableLayoutPanel2.Controls.Add(Hubraumlbl, 0, 6);
                    tableLayoutPanel2.Controls.Add(HubraumText, 1, 6);
                    tableLayoutPanel2.Controls.Add(SteuerschuldText, 1, 7);
                    tableLayoutPanel2.Controls.Add(steuerschuldlbl, 0, 7);
                    //Hiermit lass ich die Werte sofort ausgeben wenn das gesuchte Kennzeichen gefunden wurde
                    HubraumText.Text = ((Motorräder)fahrzeug).Hubraum;
                    HerstellerText.Text = ((Motorräder)fahrzeug).MotoMarke;
                    SteuerschuldText.Text = Convert.ToString(((Motorräder)fahrzeug).Steuerschuld);
                }
            }
        } //Meine Suchfunktion, die das Kennzeichen sucht und dann die Daten direkt ausgibt 

        private void TextLöschen()
        {
           
            
        } //Soll eigentlich löschen jedoch klappt es nicht, da ich auf clear Methode zugreifen kann

        private void Hilfebtn_Click(object sender, EventArgs e)//Dies ist nur dafür da damit man sich orientieren kann
        {
            MessageBox.Show("Die Kennzeichen die schon Gespeichert sind muss man einmal anklicken und den Rest 2mal",
                "Hilfe zur meiner Liste", MessageBoxButtons.RetryCancel);
        }
    }
}

