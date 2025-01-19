typedef struct {
    int min;
    int stackSize;
    int stackCap;
    int *stack;
} MinStack;


MinStack* minStackCreate() {
    MinStack *obj = calloc(1, sizeof(MinStack));
    obj->stackSize = 0;
    obj->stackCap = 4;
    obj->min = INT_MAX;
    obj->stack = calloc(4, sizeof(int));
    return obj;
}


void minStackResize(MinStack* obj) {
    obj->stackCap *= 2;
    int *new_stack = realloc(obj->stack, sizeof(int) * obj->stackCap);
    obj->stack = new_stack;
}

void minStackPush(MinStack* obj, int val) {
    if (obj->stackSize == obj->stackCap)
        minStackResize(obj);
    obj->stack[obj->stackSize] = val;
    obj->stackSize++;

    if (val < obj->min)
        obj->min = val;
}

void minStackPop(MinStack* obj) {
    obj->stackSize--;
    int top = obj->stack[obj->stackSize];
    
    if (top == obj->min) {
        int new_min = INT_MAX;

        for(int i = obj->stackSize-1; i >= 0; i--)
            if (obj->stack[i] < new_min)
                new_min = obj->stack[i];
        
        obj->min = new_min;
    }
}

int minStackTop(MinStack* obj) {
    return obj->stack[obj->stackSize-1];
}

int minStackGetMin(MinStack* obj) {
    return obj->min;
}

void minStackFree(MinStack* obj) {
    free(obj->stack);
    free(obj);
}

