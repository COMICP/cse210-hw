using System;

static float math(int num1, int num2, string arg){
    float ans;
    if (arg == "add"){
        ans = add(num1, num2);
    }
    else if (arg == "subtract"){
        ans = sub(num1, num2);
    }
    else if (arg == "multiply"){
        ans = mult(num1, num2);
    }
    else if (arg == "divide"){
        ans = div(num1, num2);
    }
    return ans;

}


static int add(int num1, int num2){
    int ans = num1 + num2;
    return ans;

}
static int sub(int num1, int num2){
    int ans = num1 - num2;
    return ans;
}
static int mult(int num1, int num2){
    int ans = num1 * num2;
    return ans;
    
}
static int div(int num1, int num2){
    int ans = num1 / num2;
    return ans;
    
}

int added = num1 + num2;

