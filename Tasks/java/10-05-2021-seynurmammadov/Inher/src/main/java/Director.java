public  interface Director  {
    void toOrder();
}
class Test{
    public static void main(String[] args) {
        Director director = new Director() {
            @Override
            public void toOrder() {
                System.out.println("hello");
            }
        };
        director.toOrder();
    }
}
