package reciever;

public class ReportBatteryPropeties implements PrintProperty {

	public void printReport(BatteryProperties battery) {

		System.out.println("Max Temp: " + battery.getMaxChargeRate());
		System.out.println("Min Temp: " + battery.getMinChargeRate());
		System.out.println("Avg Temp: " + battery.getAverageChargeRate());
		System.out.println("Maximum state of charge: " + battery.getMaxSoc());
		System.out.println("Minimum state of charge: " + battery.getMinSoc());
		System.out.println("Average state of charge: " + battery.getAverageSoc());
	}
}