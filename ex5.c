void main(Int n) {
  do{
    print n;
    n++;
    (*n++;*)
  } while (n <= 10);
  println;
}
