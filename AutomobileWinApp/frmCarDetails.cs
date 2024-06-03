using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp;

public partial class frmCarDetails : Form
{
    public frmCarDetails()
    {
        InitializeComponent();
    }

    public ICarRepository CarRepository { get; set; }
    public bool InsertOrUpdate { get; set; }
    public Car CarInfo { get; set; }

    private void frmCarDetails_Load(object sender, EventArgs e)
    {
        cboManufacturer.SelectedIndex = 0;
        txtCarID.Enabled = !InsertOrUpdate;

        if (InsertOrUpdate)
        {
            txtCarID.Text = CarInfo.CarID.ToString();
            txtCarName.Text = CarInfo.CarName;
            cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            txtPrice.Text = CarInfo.Price.ToString();
            txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var car = new Car
            {
                CarID = int.Parse(txtCarID.Text),
                CarName = txtCarName.Text,
                Manufacturer = cboManufacturer.Text,
                Price = decimal.Parse(txtPrice.Text),
                ReleaseYear = int.Parse(txtReleaseYear.Text)
            };

            if (InsertOrUpdate)
            {
                CarRepository.UpdateCar(car);
            }
            else
            {
                CarRepository.InsertCar(car);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, InsertOrUpdate ? "Update a car" : "Add a new car");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) => Close();
}