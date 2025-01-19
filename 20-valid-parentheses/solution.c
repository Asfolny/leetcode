bool isValid(char* s) {
    int len = strlen(s);

    // if (len < 2)
    //     return s[0] != '(' && s[0] != '[' && s[0] != '{' && s[0] != ')' && s[0] != ']' && s[0] != '}';
    
    int stackSize = 0;
    char stack[len];
    
    for (int i = 0; i < len; i++) {
        char c = s[i];
        char counter = '\0';
        switch(c) {
            case '(':
            case '[':
            case '{':
                if (stackSize + 1 > len / 2)
                    return false;
                stack[stackSize] = c;
                stackSize++;
                break;

            case ')':
                counter = '(';
            case ']':
                if (counter == '\0')
                    counter = '[';
            case '}':
                if (counter == '\0')
                    counter = '{';
                if (stackSize == 0)
                    return false;
                if (stack[stackSize-1] != counter)
                    return false;
                stackSize--;
        }
    }

    return stackSize == 0;
}

