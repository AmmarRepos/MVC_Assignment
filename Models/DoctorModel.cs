namespace mvc_cli.Models;

public class DoctorModel
{
    public static string checkFever(string temperature) {
	int temp = int.Parse(temperature);
	string feverMsg;
	feverMsg = (temp >= 37) ? "Sick" : "Normal";
	return feverMsg;
    }
}
