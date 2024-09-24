#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#pragma warning (disable : 4996)

struct FlightDestination
{
    char source[50];
    char destination[50];
    char airline[50];
    int fare;
};


int processFlight(char fileName[40], struct FlightDestination* structOfFlightsArray, int* totalCount);

int main(void)
{
 
    FILE* fpFlights = NULL;

    char fileName[100] = "";
    char flightsArray[100][50] = { "" };

    struct FlightDestination arrayOflights[100] = {};

    int countFlights = 0;

    fpFlights = fopen("flights.txt", "r"); // Open flightsFile

    if (fpFlights == NULL) // Check if file opened
    {
        printf("Error: Couldn't open file");
        return -1;
    }

    // Read file

    while (fgets(fileName, 50, fpFlights) != NULL)
    {
        char flightName[100];
        fileName[strcspn(fileName, "\n")] = '\0';

        sscanf(fileName, "%[^.]", flightName); 

        strcpy(flightsArray[countFlights], flightName);

         printf("%s\n", flightName);
        countFlights++;
    }

    int flightsFileClose = fclose(fpFlights);
    if (flightsFileClose != 0)
    {
        printf("File couldn't close");
        return -1;
    }

    return 0;
}

int processFlight(char fileName[40], struct FlightDestination* arrayOflights, int* totalCount)
{
    FILE* flightsFile = NULL;
    char filePath[50] = "";

    char fileLine[50] = "";
    char source[50] = "";
    char destination[50] = "";
    int fare = 0;
  

    strcpy(filePath, fileName);

    strcat(filePath, ".txt");

    flightsFile = fopen(filePath, "r");

    if (flightsFile == NULL)
    {
        printf("Couldn't open file");

        return -1;
    }

    while (fgets(fileLine, 50, flightsFile) != NULL && *totalCount < 101)
    {
        fileLine[strcspn(fileLine, "\n")] = '\0';

        if (strlen(fileName) < 2)
        {
            continue;
        }

    return 0;
}



