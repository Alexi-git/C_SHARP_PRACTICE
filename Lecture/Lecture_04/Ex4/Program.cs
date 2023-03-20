

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)


        int F (int n)
        {
            if (n == 1 || n == 2) return 1;
            else F(int n - 1) + F(int n - 2);
        }

