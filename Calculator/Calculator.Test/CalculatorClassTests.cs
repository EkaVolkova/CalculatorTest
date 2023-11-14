using NUnit.Framework;
using System;

/// <summary>
/// Тесты для проекта Calculator
/// </summary>
namespace Calculator.Test
{
    /// <summary>
    /// Тесты класса Calculator
    /// </summary>
    [TestFixture]
    public class CalculatorClassTests
    {

        /// <summary>
        /// Тестирование функции сложения
        /// </summary>
        [Test]
        public void AdditionalMustReurnCorrectResult()
        {
            var calc = new Calculator();

            //Проверяем сложение двух положительных чисел
            Assert.AreEqual(30, calc.Additional(10, 20));

            //Проверяем сложение с нулем
            Assert.AreEqual(20, calc.Additional(0, 20));

            //Проверяем сложение с отрицательным числом
            Assert.AreEqual(10, calc.Additional(-10, 20));

            //Проверяем сложениеотрицательных чисел
            Assert.AreEqual(-30, calc.Additional(-10, -20));
        }

        /// <summary>
        /// Тестирование функции вычитания
        /// </summary>
        [Test]
        public void SubtractionMustReurnCorrectResult()
        {
            var calc = new Calculator();

            //Проверяем вычитание двух положительных чисел (1 число > 2 числа)
            Assert.AreEqual(10, calc.Subtraction(20, 10));

            //Проверяем вычитание двух положительных чисел (2 число > 1 числа)
            Assert.AreEqual(-10, calc.Subtraction(10, 20));

            //Проверяем вычитание из нуля положительного числа
            Assert.AreEqual(-20, calc.Subtraction(0, 20));

            //Проверяем вычитание положительного числа из отрицательного числа
            Assert.AreEqual(-30, calc.Subtraction(-10, 20));

            //Проверяем вычитание отрицательного числа из положительного числа
            Assert.AreEqual(30, calc.Subtraction(10, -20));

            //Проверяем вычитание отрицательного числа из отрицательного числа
            Assert.AreEqual(10, calc.Subtraction(-10, -20));
        }

        /// <summary>
        /// Тестирование функции умножения
        /// </summary>
        [Test]
        public void MiltiplicationMustReurnCorrectResult()
        {
            var calc = new Calculator();
            //Проверяем умножение двух положительных чисел
            Assert.AreEqual(200, calc.Miltiplication(20, 10));

            //Проверяем умножение положительного числа и нуля
            Assert.AreEqual(0, calc.Miltiplication(0, 20));

            // Проверяем умножение отрицательного числа и нуля
            Assert.AreEqual(0, calc.Miltiplication(0, -20));

            //Проверяем умножение отрицательного и положительного чисел
            Assert.AreEqual(-200, calc.Miltiplication(-10, 20));

            //Проверяем умножение отрицательных чисел
            Assert.AreEqual(200, calc.Miltiplication(-10, -20));
        }

        /// <summary>
        /// Тестирование функции деления
        /// </summary>
        [Test]
        public void DivisionMustReurnCorrectResult()
        {
            var calc = new Calculator();

            //Деление положительного числа на положительное число (1 число > 2 числа)
            Assert.AreEqual(2, calc.Division(20, 10));

            //Деление положительного числа на положительное число (2 число > 1 числа)
            Assert.AreEqual(0, calc.Division(10, 20));

            //Деление положительного числа на положительное число (2 число > 1 числа, не делится нацело)
            Assert.AreEqual(4, calc.Division(30, 7));

            //Деление отрицательного числа на положительное число (1 число > 2 числа)
            Assert.AreEqual(-2, calc.Division(-15, 6));

            //Деление отрицательного числа на положительное число (2 число > 1 числа)
            Assert.AreEqual(0, calc.Division(-10, 20));

            //Деление отрицательного числа на отрицательного число (1 число > 2 числа)
            Assert.AreEqual(2, calc.Division(-20, -10));

            //Деление отрицательного числа на отрицательного число (2 число > 1 числа)
            Assert.AreEqual(0, calc.Division(-10, -20));
        }

        /// <summary>
        /// Тестирование функции деления при делении на 0
        /// </summary>
        [Test]
        public void DivisionMustReturnDivideByZeroException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(20, 0));
        }

        }
}
