int F(int a, int b, int n) {
    if (n == 1) return a + b;
    return F(b, a + b, n - 1);
}

int fib(int n) {
    if (n < 2)
        return n;
    return F(1, 0, n);
}

