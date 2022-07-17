import az.code.model.Coffee;
import az.code.model.Expresso;
import az.code.model.IceLatte;
import az.code.model.Latte;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Coffee[] a = new Coffee[]{new Expresso(), new Coffee()};

//
//
//        for(Coffee coffee : new CoffeeGenerator(2)){
//            System.out.println(coffee);
//        }

//        List<Latte> listCoffee = new ArrayList<>();
////        listCoffee.add(new Coffee());
//        listCoffee.add(new Latte());
//        listCoffee.add(new IceLatte());
////        listCoffee.add(new Expresso());
////        listCoffee.add(new Expresso());
//
//        List<? super Latte> litOfParent = listCoffee;
//        litOfParent.add(new IceLatte());


    }
//    public static void main(String[] args) {
////        SimpleGenerics<Car> simpleGenerics =  new SimpleGenerics<>(new Car());
////        Car c = getCarsWithName().first;
////        String d = getCarsWithName().second;
////        System.out.println(getName(new Car()));
//    }
    public static Pair<Car, String> getCarsWithName(){
        return new Pair<>(new Car(), "Mercedes");
    }

    public static Pair<Integer, String> getIdWithName(){
        return new Pair<>(5, "Mercedes");
    }

    public static Triple<Integer, String, Car> getIdNameAndCar(){
        return new Triple<>(5, "Mercedes", new Car());
    }

    public static <T extends Number> T getName(T object, T obj2){
        return obj2;
    }
}
