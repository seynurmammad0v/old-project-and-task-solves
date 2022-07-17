package com.company;


public class MyBigInteger {

    private String bigInteger;

    public MyBigInteger() {
    }

    public MyBigInteger(String bigInteger) {
        this.bigInteger = bigInteger;
    }

    public String getBigInteger() {
        return bigInteger;
    }

    public void setBigInteger(String bigInteger) {
        this.bigInteger = bigInteger;
    }


    public char[] chars() {
        return this.bigInteger.toCharArray();
    }

    public int length() {
        return this.bigInteger.length();
    }

    public char firstElement() {
        return this.bigInteger.charAt(0);
    }

    public boolean isNegative() {
        if (this.firstElement() == '-') {
            return true;
        }
        return false;
    }

    public boolean isPositive() {
        return !this.isNegative();
    }


    public char[] getMagnitude() {
        if (this.isNegative()) {
            char[] negativeChars = this.chars();
            char[] positiveChars = new char[negativeChars.length - 1];
            for (int i = 0; i < positiveChars.length; i++) {
                positiveChars[i] = negativeChars[i + 1];
            }
            return positiveChars;
        } else {
            return this.chars();
        }
    }

    public int compareMagnitude(MyBigInteger value) {
        if (this.length() > value.length()) {
            return 1;
        } else if (this.length() < value.length()) {
            return -1;
        } else {
            char[] digits1 = this.getMagnitude();
            char[] digits2 = value.getMagnitude();



            for (int i1 : digits1) {
                for (int i2 : digits2) {
                    if (i1 > i2) {
                        return 1;
                    } else if (i1 < i2) {
                        return -1;
                    }
                }
            }

        }
        return 0;
    }

    public MyBigInteger max(MyBigInteger value) {
        if (this.isNegative() && value.isNegative()) {
            int comparingResult = this.compareMagnitude(value);
            if (comparingResult == 1) {
                return value;
            } else if (comparingResult == -1) {
                return this;
            } else {
                System.out.println("These numbers are equal");
                return this;
            }

        } else if (this.isPositive() && value.isPositive()) {
            int comparingResult = compareMagnitude(value);
            if (comparingResult == 1) {
                return this;
            } else if (comparingResult == -1) {
                return value;
            } else {
                System.out.println("These numbers are equal");
                return this;
            }

        } else if (this.isPositive() && value.isNegative()) {
            return this;
        } else {
            return value;
        }

    }

    private static String[] addZerosToShort(MyBigInteger number1, MyBigInteger number2) {
        String value1 = number1.getBigInteger();
        String value2 = number2.getBigInteger();

        if (number1.length() > number2.length())
            value2 = "0".repeat(number1.length() - number2.length()) + number2.getBigInteger();
        else if (number1.length() < number2.length())
            value1 = "0".repeat(number2.length() - number1.length()) + number1.getBigInteger();

        return new String[]{value1, value2};
    }

    public static MyBigInteger toPositive(MyBigInteger myBigInteger) {
        String positiveValues = myBigInteger.bigInteger.substring(1);
        MyBigInteger positiveBigInteger = new MyBigInteger(positiveValues);
        return positiveBigInteger;
    }

    public static MyBigInteger toNegative(MyBigInteger myBigInteger) {
        String negativeValues = "-" + myBigInteger.bigInteger;
        MyBigInteger negativeBigInteger = new MyBigInteger(negativeValues);
        return negativeBigInteger;
    }

    public static MyBigInteger removeDoubleNegative(MyBigInteger myBigInteger) {
        String value = myBigInteger.getBigInteger();
        if (value.toCharArray()[0] == '-' && value.toCharArray()[1] == '-') {
            value = value.substring(2);
        }
        MyBigInteger correctedBigInteger = new MyBigInteger(value);
        return correctedBigInteger;
    }


    public MyBigInteger add(MyBigInteger value) {

        MyBigInteger resultBigInteger = new MyBigInteger();
        if (this.isPositive() && value.isPositive()) {
            String[] numberArray = addZerosToShort(value, this);
            char[] number1 = numberArray[0].toCharArray();
            char[] number2 = numberArray[1].toCharArray();

            int carry = 0;

            StringBuilder result = new StringBuilder();
            for (int i = number1.length - 1; i >= 0; i--) {
                int digit1 = Character.getNumericValue(number1[i]);
                int digit2 = Character.getNumericValue(number2[i]);
                int digitSum = digit1 + digit2 + carry;

                result.append(digitSum % 10);
                carry = digitSum / 10;
            }
            this.bigInteger = (carry == 0 ? "" : "1") + result.reverse().toString();
            resultBigInteger = this;

        } else if (this.isNegative() && value.isNegative()) {
            MyBigInteger value1 = toPositive(this);
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = toNegative(value1.add(value2));
        } else if (this.isPositive() && value.isNegative()) {
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = this.subtract(value2);
        } else if (this.isNegative() && value.isPositive()) {
            MyBigInteger value1 = toPositive(this);
            resultBigInteger = value.subtract(value1);
        }
        return resultBigInteger;
    }


    public MyBigInteger subtract(MyBigInteger value) {

        MyBigInteger resultBigInteger = new MyBigInteger();
        if (this.isPositive() && value.isPositive()) {

            int firstValueGreater = this.compareMagnitude(value);
            if (firstValueGreater == 0) {
                this.setBigInteger("0");
                resultBigInteger = this;
            } else if (firstValueGreater == 1) {
                String[] numberArray = addZerosToShort(value, this);
                char[] number1 = numberArray[0].toCharArray();
                char[] number2 = numberArray[1].toCharArray();

                int carry = 0;
                StringBuilder result = new StringBuilder();
                for (int i = number1.length - 1; i >= 0; i--) {
                    int digit1 = Character.getNumericValue(number1[i]);
                    int digit2 = Character.getNumericValue(number2[i]) + carry;
                    carry = 0;

                    if (digit2 < digit1) {
                        carry = -1;
                        digit2 += 10;
                    }

                    result.append(digit2 - digit1);
                }

                while (result.charAt(result.length() - 1) == '0') {
                    result.deleteCharAt(result.length() - 1);
                }
                this.setBigInteger(result.reverse().toString());
                resultBigInteger = this;

            } else if (firstValueGreater == -1) {
                resultBigInteger = toNegative(value.subtract(this));
            }

        } else if (this.isNegative() && value.isNegative()) {
            MyBigInteger value1 = toPositive(this);
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = value2.subtract(value1);
        } else if (this.isPositive() && value.isNegative()) {
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = this.add(value2);
        } else if (this.isNegative() && value.isPositive()) {
            MyBigInteger value1 = toPositive(this);
            resultBigInteger = toNegative(value1.add(value));
        }
        return resultBigInteger;
    }


    public static MyBigInteger addZerosToLast(MyBigInteger myBigInteger, int numberOfZeros) {
        myBigInteger.bigInteger = myBigInteger.bigInteger + "0".repeat(numberOfZeros);
        return myBigInteger;
    }


    public MyBigInteger multiply(MyBigInteger value) {
        MyBigInteger resultBigInteger = new MyBigInteger("0");
        if (this.isPositive() && value.isPositive()) {
            MyBigInteger stair = new MyBigInteger("0");
            char[] number2 = value.chars();
            String number1 = this.getBigInteger();
            for (int i = 0; i < number2.length; i++) {
                stair.setBigInteger("0");
                int digit2 = Character.getNumericValue(number2[number2.length - 1 - i]);
                for (int j = 0; j < digit2; j++) {
                    stair.add(new MyBigInteger(number1));
                }
                stair = addZerosToLast(stair, i);
                resultBigInteger.add(stair);
            }
        } else if (this.isNegative() && value.isNegative()) {
            MyBigInteger value1 = toPositive(this);
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = value2.multiply(value1);
        } else if (this.isNegative() && value.isPositive()) {
            MyBigInteger value1 = toPositive(this);
            resultBigInteger = toNegative(value1.multiply(value));
        } else if (this.isPositive() && value.isNegative()) {
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = toNegative(this.multiply(value2));
        }
        return resultBigInteger;
    }

    public MyBigInteger divide(MyBigInteger value) {

        MyBigInteger resultBigInteger = new MyBigInteger("0");
        MyBigInteger one = new MyBigInteger("1");

        if (this.isPositive() && value.isPositive()) {
            while (!(this.compareMagnitude(value)<0)) {
                this.subtract(value);
                resultBigInteger.add(one);
            }
        }else if (this.isNegative() && value.isNegative()) {
            MyBigInteger value1 = toPositive(this);
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = value1.divide(value2);
        } else if (this.isNegative() && value.isPositive()) {
            MyBigInteger value1 = toPositive(this);
            resultBigInteger = toNegative(value1.divide(value));
        } else if (this.isPositive() && value.isNegative()) {
            MyBigInteger value2 = toPositive(value);
            resultBigInteger = toNegative(this.divide(value2));
        }
        return resultBigInteger;
    }


}

