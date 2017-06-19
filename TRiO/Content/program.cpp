#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
#include <math.h>
#include <sstream>
#include <cstdlib>
#include <stdlib.h>

using namespace std;

int main()
{
    fstream cmdReader, txtReader, msgReader;
    string cmdFileName, txtFileName, msgFileName;
        
    //#0 Display the copyright notice.
    cout << "(c) 2017, rDortch Randy Dortch" << endl;
    cout << endl;
    
    //#1 Read names of files.
	cout << "Please enter the name of the command file: ";
	cin >> cmdFileName;
	cout << "Please enter the name of the text file: ";
	cin >> txtFileName;
	cout << "Please enter the name of the message file: ";
	cin >> msgFileName;
	cout << endl;
	
	//#2 Open files and terminate if not opened.
	cmdReader.open(cmdFileName);
	txtReader.open(txtFileName);
	msgReader.open(msgFileName);
	
	if(!cmdReader.is_open()) 
	{
		cout << "There was a problem opening the command file." << endl;
		exit(EXIT_FAILURE);
	}
	else if(!txtReader.is_open())
	{
		cout << "There was a problem opening the text file." << endl;
		exit(EXIT_FAILURE);
	}
	else if(!msgReader.is_open())
	{
		cout << "There was a problem opening the message file." << endl;
		exit(EXIT_FAILURE);
	}
    
    //#3 Initialize message line to empty string.
    cout << "Enter the average speed to work: ";
    cin >> w_mph;
    cout << "Enter the average speed to home: ";
    cin >> h_mph;
    cout << endl;
    
    //#4 Read the driver's data from the input file.
    fileReader >> driversName >> x1 >> y1 >> x2 >> y2 >> hr1 >> colon1 >> min1 >> hr2 >> colon2 >> min2;
    
    //This allows me the format the time into a string, so that whenever I need to display the time, I don't have to worry about C++ dropping any of the digits.
    stream1 << setfill('0') << setw(2) << hr1 << ":" << setfill('0') << setw(2) << min1;
    time1 = stream1.str();
    stream2  << setfill('0') << setw(2) << hr2 << ":" << setfill('0') << setw(2) << min2;
    time2 = stream2.str();
    
    //#5 Display the driver's information
    cout << driversName << " lives at (" << setprecision(2) << fixed << x1 << "," << y1 << "), works at (" << x2 << "," << y2 << ")" << endl;;
    cout << driversName << " reports to work at " << time1 << ", and leavs work at " << time2 << "." << endl;
    cout << endl;
    
    //#6 Calculate the distance between work and home.
    xCord = x1 - x2;
    yCord = y1 - y2;
    xCord = pow(xCord, 2);
    yCord = pow(yCord, 2);
    d2 = xCord + yCord;
    distance = sqrt(d2);
    
    //#7 Display the distance from home to work.
    cout << "A. DRIVER " << driversName << "travels " << setprecision(2) << fixed << distance << " miles one-way to work." << endl;
    
    //#8 Calculate the time taken from home to work.
    timeToWork = distance/w_mph;
    timeToWork = timeToWork * 60;
    
    //#9 Display the time from home to work for the driver.
    cout << "B. One-way DRIVING TIME FROM HOME TO WORK FOR " << driversName << " is " << setprecision(1) << fixed << timeToWork << " minutes (@ " << w_mph << " mph)" << endl;
    
    //#10 Calculate the time taken from work to home.
    timeToHome = distance/h_mph;
    timeToHome = timeToHome * 60;
    
    //#11 Display the time from work to home for the driver.
    cout << "C. One-way DRIVING TIME FROM WORK TO HOME for " << driversName << " is " << timeToHome << " minutes (@ " << h_mph << " mph)" << endl;
    
    //#12 Display the driver's start work time.
    cout << "D. DRIVER " << driversName << " STARTS WORK at " << time1 << endl;
    
    //#13 Calclate the time the driver must leave home.
    timeToStart = hr1 * 60 + min1;
    timeToLeave = timeToStart - timeToWork;
    hourToLeave = timeToLeave/60;
    minToLeave = timeToLeave%60;
    
    stream3 << setfill('0') << setw(2) << hourToLeave << ":" << setfill('0') << setw(2) << minToLeave;
    time3 = stream3.str();
    
    //#14 Display the time that the driver must leave home.
    cout << "E. DRIVER " << driversName << " MUST LEAVE HOME at " << time3 << endl;
    
    //#15 Display the time the driver leaves work.
    cout << "F. DRIVER " << driversName << " LEAVES WORK at " << time2 << endl;
    
    //#16 Calculate the time the driver arrives home.
    timeToEnd = hr2 * 60 + min2;
    timeHome = timeToEnd + timeToHome;
    hourToHome = timeHome / 60;
    minToHome = timeHome % 60;
    
    stream4 << setfill('0') << setw(2) << hourToHome << ":" << setfill('0') << setw(2) << minToHome;
    time4 = stream4.str();
    
    //#17 Display the time the driver arrives home.
    cout << "DRIVER " << driversName << " WILL ARRIVE BACK HOME at " << hourToHome << ":" << minToHome << endl;
    
    //#18 Display the copyright notice
    cout << endl;
    cout << "(c) 2017, rDortch Randy Dortch" << endl;
    cout << endl;
}
