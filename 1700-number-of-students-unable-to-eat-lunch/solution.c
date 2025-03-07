int countStudents(int* students, int studentsSize, int* sandwiches, int sandwichesSize) {    
    int run = 0;

    while (studentsSize > 0) {
        run++;
        int student = students[0];

        for (int i = 1; i < studentsSize; i++) {
            int tmp = students[i];
            students[i] = students[i-1];
            students[i-1] = tmp;
        }

        if (student == sandwiches[0]) {
            for (int i = 1; i < sandwichesSize; i++) {
                int tmp = sandwiches[i];
                sandwiches[i] = sandwiches[i-1];
                sandwiches[i-1] = tmp;
            }

            studentsSize--;
            sandwichesSize--;
            run = 0;
        }

        if (run == studentsSize)
            return run;
    }

    return 0;
}

