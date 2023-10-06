// Create a Loop that prints all values from 1-255
for(int i=1;i<=255;i++){
  Console.WriteLine(i);
}

// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
for(int j=1;j<=100;j++){
  if((j%3 == 0 || j%5 == 0) && !(j%3 == 0 && j%5 == 0)){
    Console.WriteLine(j);
  }
}

// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
for(int k=1;k<=100;k++){
  if(k%3==0 && k%5==0){
    Console.WriteLine("FizzBuzz");
  }else if(k%3 == 0){
    Console.WriteLine("Fizz");
  }else if(k%5 == 0){
    Console.WriteLine("Buzz");
  }
}

// (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
// Create a Loop that prints all values from 1-255
int l = 1;
while(l <= 255){
  Console.WriteLine(l);
  l++;
}

// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
int m = 1;
while(m <= 100){
  if((m%3 == 0 || m%5 == 0) && !(m%3 == 0 && m%5 == 0)){
    Console.WriteLine(m);
  }
  m++;
}

// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
int n = 1;
while(n <= 100){
  if(n%3 == 0 && n%5 == 0){
    Console.WriteLine("FizzBuzz");
  }else if(n%3 == 0){
    Console.WriteLine("Fizz");
  }else if(n%5 == 0){
    Console.WriteLine("Buzz");
  }
  n++;
}