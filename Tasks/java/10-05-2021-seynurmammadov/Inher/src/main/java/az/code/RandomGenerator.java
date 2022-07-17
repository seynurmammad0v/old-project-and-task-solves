package az.code;

public class RandomGenerator {
    public static int generateRandomNumber(int min, int max){
        return (int)(Math.random()*(max-min) + min);
    }
}
