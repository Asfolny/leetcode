int fib(int n) {
    if (n < 2)
        return n;

    int a = 1;
    int b = 0;
    while (--n) {
        int tmp = a + b;
        a = b;
        b = tmp;
    }

    return a + b;
}

