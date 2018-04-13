using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// there is a problem with my fonts for the DataGridView, everytime the app runs and when I exit it the font will reset its size and style

namespace dunwoody_residency
{
    public partial class form_resident : Form
    {
        // declare list of Resident class objects
        List<Resident> listOfResidents = new List<Resident>();

        public form_resident()
        {
            InitializeComponent();
            listOfResidents = readInResidents();
            data_residents.DataSource = listOfResidents;
        }
        // allows the window form to be movable without the title bar, must click top of window
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void form_resident_Load(object sender, EventArgs e)
        {

        }
        // read in residents from .csv file
        public static List<Resident> readInResidents()
        {
            // DECLARATIONS
            List<Resident> residents = new List<Resident>();

            Worker studentWorker;
            Athlete studentAthlete;
            Scholarships studentScholar;
            // delcare a delimiter to split data
            const char DELIMETER = ',';
            string[] arrayOfValues; //array will hold the values being passed in from datasheet
            const string FILEPATH = @"C:\schooldata\semester3\AdvancedProgramming\Project-3\dunwoody_residency\student_info.csv";
            Random randomId = new Random(); // helps generate random number for Student ID

            try
            {
                FileStream file = new FileStream(FILEPATH, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(file);

                while (!read.EndOfStream)
                {
                    arrayOfValues = read.ReadLine().Split(DELIMETER); // splits values with comma
                    switch (arrayOfValues[3])
                    {
                        case "Worker":
                            studentWorker = new Worker(arrayOfValues[0], arrayOfValues[1], randomId.Next(100, 555), arrayOfValues[3], 
                                Convert.ToDouble(arrayOfValues[4]), Convert.ToInt32(arrayOfValues[5]), Convert.ToInt32(arrayOfValues[6]));
                            residents.Add(studentWorker);
                            break;
                        case "Athlete":
                            studentAthlete = new Athlete(arrayOfValues[0], arrayOfValues[1], randomId.Next(100, 555), arrayOfValues[3],
                                Convert.ToDouble(arrayOfValues[4]), Convert.ToInt32(arrayOfValues[5]), Convert.ToInt32(arrayOfValues[6]));
                            residents.Add(studentAthlete);
                            break;
                        case "Scholarship":
                            studentScholar = new Scholarships(arrayOfValues[0], arrayOfValues[1], randomId.Next(100, 555), arrayOfValues[3],
                                Convert.ToDouble(arrayOfValues[4]), Convert.ToInt32(arrayOfValues[5]), Convert.ToInt32(arrayOfValues[6]));
                            residents.Add(studentScholar);
                            break;
                    }
                }
                read.Close(); // close reader
                file.Close(); // close file
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return residents;
        }
        // end read in



        // take user back to login page
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            form_login login = new form_login();
            login.Show();
        }

        // SEARCH (By ID)
        private void btn_search_Click(object sender, EventArgs e)
        {
            string search = textBox_search.Text;

            
        }
    }
}
