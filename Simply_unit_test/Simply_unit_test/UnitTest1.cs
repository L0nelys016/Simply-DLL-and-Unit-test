using Simply_DLL;

namespace Simply_unit_test
{
    namespace Simply_DLL.Tests
    {
        public class Class1Tests
        {
            [Fact]
            public void CalculateFactorial_ValidInput_ReturnsCorrectFactorial()
            {
                // Arrange
                double numberToFactorial = 6; // Число, для которого вычисляем факториал
                double expectedResult = 720; // Ожидаемый результат

                // Act
                double actualResult = Class1.CalculateFactorial(numberToFactorial); // Фактический результат

                // Assert
                Assert.Equal(expectedResult, actualResult);
            }

            [Fact]
            public void CalculateFactorial_NegativeInput_ThrowsArgumentOutOfRangeException()
            {
                // Arrange
                double invalidInput = -5; // Некорректный ввод (отрицательное число)

                // Act
                var exception = Assert.Throws<ArgumentOutOfRangeException>(() => Class1.CalculateFactorial(invalidInput));
                //Assert
                Assert.Contains("Значение должно быть неотрицательным.", exception.Message);
            }

            [Fact]
            public void IsPrime_PrimeNumber_ReturnsTrue()
            {
                // Arrange
                double primeCandidate = 13; // Кандидат в простые числа

                // Act
                bool isActuallyPrime = Class1.IsPrime(primeCandidate); // Является ли число простым

                // Assert
                Assert.True(isActuallyPrime);
            }

            [Fact]
            public void IsPrime_CompositeNumber_ReturnsFalse()
            {
                // Arrange
                double compositeCandidate = 20; // Кандидат в составные числа
                bool expectedResult = false; // Ожидаемый результат

                // Act
                bool isActuallyPrime = Class1.IsPrime(compositeCandidate); // Является ли число простым

                // Assert
                Assert.Equal(expectedResult, isActuallyPrime);
            }

            [Fact]
            public void IsPrime_NumberOne_ReturnsFalse()
            {
                // Arrange
                double numberOne = 1; // Число 1
                bool expectedResult = false; // Ожидаемый результат

                // Act
                bool isActuallyPrime = Class1.IsPrime(numberOne); // Является ли число простым

                // Assert
                Assert.Equal(expectedResult, isActuallyPrime);
            }

            [Fact]
            public void IsPrime_NumberZero_ReturnsFalse()
            {
                // Arrange
                double numberZero = 0; // Число 0
                bool expectedResult = false; // Ожидаемый результат

                // Act
                bool isActuallyPrime = Class1.IsPrime(numberZero); // Является ли число простым

                // Assert
                Assert.Equal(expectedResult, isActuallyPrime);
            }

            [Fact]
            public void ArithmeticProgressionTerm_ValidInput_ReturnsCorrectTerm()
            {
                // Arrange
                int termIndex = 7; // Индекс члена прогрессии
                double initialTerm = 1; // Первый член прогрессии
                double commonDifferenceAmount = 4; // Разность прогрессии
                double expectedTermValue = 25; // Ожидаемое значение члена

                // Act
                double actualTermValue = Class1.ArithmeticProgressionTerm(termIndex, initialTerm, commonDifferenceAmount); // Фактическое значение члена

                // Assert
                Assert.Equal(expectedTermValue, actualTermValue);
            }
        }
    }
}

