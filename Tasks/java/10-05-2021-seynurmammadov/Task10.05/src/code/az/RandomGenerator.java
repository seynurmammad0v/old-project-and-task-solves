package code.az;

public class RandomGenerator {
    public static int generateRandomNumber(int min, int max){
        return (int)(Math.random()*(max-min) + min);
    }
}
