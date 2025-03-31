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
                double numberToFactorial = 6; // �����, ��� �������� ��������� ���������
                double expectedResult = 720; // ��������� ���������

                // Act
                double actualResult = Class1.CalculateFactorial(numberToFactorial); // ����������� ���������

                // Assert
                Assert.Equal(expectedResult, actualResult);
            }

            [Fact]
            public void CalculateFactorial_NegativeInput_ThrowsArgumentOutOfRangeException()
            {
                // Arrange
                double invalidInput = -5; // ������������ ���� (������������� �����)

                // Act
                var exception = Assert.Throws<ArgumentOutOfRangeException>(() => Class1.CalculateFactorial(invalidInput));
                //Assert
                Assert.Contains("�������� ������ ���� ���������������.", exception.Message);
            }

            [Fact]
            public void IsPrime_PrimeNumber_ReturnsTrue()
            {
                // Arrange
                double primeCandidate = 13; // �������� � ������� �����

                // Act
                bool isActuallyPrime = Class1.IsPrime(primeCandidate); // �������� �� ����� �������

                // Assert
                Assert.True(isActuallyPrime);
            }

            [Fact]
            public void IsPrime_CompositeNumber_ReturnsFalse()
            {
                // Arrange
                double compositeCandidate = 20; // �������� � ��������� �����
                bool expectedResult = false; // ��������� ���������

                // Act
                bool isActuallyPrime = Class1.IsPrime(compositeCandidate); // �������� �� ����� �������

                // Assert
                Assert.Equal(expectedResult, isActuallyPrime);
            }

            [Fact]
            public void IsPrime_NumberOne_ReturnsFalse()
            {
                // Arrange
                double numberOne = 1; // ����� 1
                bool expectedResult = false; // ��������� ���������

                // Act
                bool isActuallyPrime = Class1.IsPrime(numberOne); // �������� �� ����� �������

                // Assert
                Assert.Equal(expectedResult, isActuallyPrime);
            }

            [Fact]
            public void IsPrime_NumberZero_ReturnsFalse()
            {
                // Arrange
                double numberZero = 0; // ����� 0
                bool expectedResult = false; // ��������� ���������

                // Act
                bool isActuallyPrime = Class1.IsPrime(numberZero); // �������� �� ����� �������

                // Assert
                Assert.Equal(expectedResult, isActuallyPrime);
            }

            [Fact]
            public void ArithmeticProgressionTerm_ValidInput_ReturnsCorrectTerm()
            {
                // Arrange
                int termIndex = 7; // ������ ����� ����������
                double initialTerm = 1; // ������ ���� ����������
                double commonDifferenceAmount = 4; // �������� ����������
                double expectedTermValue = 25; // ��������� �������� �����

                // Act
                double actualTermValue = Class1.ArithmeticProgressionTerm(termIndex, initialTerm, commonDifferenceAmount); // ����������� �������� �����

                // Assert
                Assert.Equal(expectedTermValue, actualTermValue);
            }
        }
    }
}

