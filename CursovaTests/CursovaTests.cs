using System;
using Cursova.Services;
using Cursova.Models;
using Cursova.Enums;
using Cursova;
using Xunit;


namespace CursovaTests
{
    public class RequestServiceTests
    {
        RequestService requestService = new RequestService();
        
        private Request CreateTestRequest(string fileName, string message, Operations operation, Method method, int caesarKey, string vigenereKey)
        {
            Request request = new Request();
            request.FileName = fileName;
            request.Message = message;
            request.Operation = operation;
            request.Method = method;
            request.CaesarKey = caesarKey;
            request.VigenereKey = vigenereKey;
            return request;
        }
        [Fact]
        public void GetOperationFromPresenter_ShouldGiveCorrectOperationToRequest()
        {
            //Arrange
            Request request = CreateTestRequest(null, null, Operations.Decrypt, Method.Caesar, 0, null);
            var operation = request.Operation;

            Request requestSecond = CreateTestRequest(null, null, Operations.Encrypt, Method.Caesar, 0, null);
            var operationSecond = request.Operation;

            //Act
            requestService.GetOperationFromPresenter(operation);
            var actual = requestService.request.Operation;

            requestService.GetOperationFromPresenter(operation);
            var actualSecond = requestService.request.Operation;

            //Assert
            Assert.Equal(operation, actual);
            Assert.Equal(operationSecond, actualSecond);
        }
        [Fact]
        public void GetAtbushMethodFromPresenter_ShouldGiveAtbushtMethodToRequest()
        {
            //Arrange
            Request request = CreateTestRequest(null, null, Operations.Decrypt, Method.Atbush, 0, null);
            var method = request.Method;

            //Act
            requestService.GetMethodFromPresenter(method);
            var actual = requestService.request.Method;

            //Assert
            Assert.Equal(method, actual);
        }
        [Fact]
        public void GetCaesarMethodFromPresenter_ShouldGiveCaesarMethodToRequest()
        {
            //Arrange
            Request request = CreateTestRequest(null, null, Operations.Decrypt, Method.Caesar, 0, null);
            var method = request.Method;

            //Act
            requestService.GetMethodFromPresenter(method);
            var actual = requestService.request.Method;

            //Assert
            Assert.Equal(method, actual);
        }
        [Fact]
        public void GetVigenereMethodFromPresenter_ShouldGiveVigenereMethodToRequest()
        {
            //Arrange
            Request request = CreateTestRequest(null, null, Operations.Decrypt, Method.Vigenere, 0, null);
            var method = request.Method;

            //Act
            requestService.GetMethodFromPresenter(method);
            var actual = requestService.request.Method;

            //Assert
            Assert.Equal(method, actual);
        }
        [Fact]
        public void GetCaesarKeyFromPresenter_ShouldGiveCorrectCaesarKeyToRequest()
        {
            //Arrange
            Request request = CreateTestRequest(null, null, Operations.Decrypt, Method.Caesar, 12, null);
            var key = request.CaesarKey;

            //Act
            requestService.GetCaesarKeyFromPresenter(key);
            var actual = requestService.request.CaesarKey;

            //Assert
            Assert.Equal(key, actual);
        }
        [Fact]
        public void GetVigenereKeyFromPresenter_ShouldGiveCorrectVigenereKeyToRequest()
        {
            //Arrange
            Request request = CreateTestRequest(null, null, Operations.Decrypt, Method.Caesar, 0, "ключ");
            var key = request.VigenereKey;

            //Act
            requestService.GetVigenereKeyFromPresenter(key);
            var actual = requestService.request.VigenereKey;

            //Assert
            Assert.Equal(key, actual);
        }
        [Fact]
        public void GetDecryptCaesarMessage_ShouldReturnCorrectResultWithKey_7()
        {
            //Arrange
            requestService.request.Message = "ТншщЕ хцєїєк м їйчйз, є зощйч цоїяхцтДк рхих";
            requestService.request.CaesarKey = 7;
            //Act

            var actual = requestService.GetDecryptCaesarMessage();
            var expected = "Листя опадає з дерев, а вітер підхоплює його";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetDecryptCaesarMessage_ShouldReturnCorrectResultWithKey_0()
        {
            //Arrange
            requestService.request.Message = "Листя опадає з дерев, а вітер підхоплює його";
            requestService.request.CaesarKey = 0;
            //Act

            var actual = requestService.GetDecryptCaesarMessage();
            var expected = "Листя опадає з дерев, а вітер підхоплює його";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetDecryptVigenereMessage_ShouldReturnCorrectResult()
        {
            //Arrange
            requestService.request.Message = "Лцпмйлмйлсябкхю свґь,лячнчраблндрємйьйдчшабї";
            requestService.request.VigenereKey = "ключ";
            //Act

            var actual = requestService.GetDecryptVigenereMessage();
            var expected = "Листя опадає з дерев, а вітер підхоплює його";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetDecryptVigenereMessage_ShouldReturnCorrectResultWithKey()
        {
            //Arrange
            requestService.request.Message = "Лигть їаасад гкдтрґв,калвзтаб бігхїалйєюйїоо";
            requestService.request.VigenereKey = "к л ю ч";
            //Act

            var actual = requestService.GetDecryptVigenereMessage();
            var expected = "Листя опадає з дерев, а вітер підхоплює його";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetEncryptCaesarMessage_ShouldReturnCorrectResultWithKey_7()
        {
            //Arrange
            requestService.request.Message = "Листя опадає з дерев, а вітер підхоплює його";
            requestService.request.CaesarKey = 7;
            //Act

            var actual = requestService.GetEncryptCaesarMessage();
            var expected = "ТншщЕ хцєїєк м їйчйз, є зощйч цоїяхцтДк рхих";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetEncryptCaesarMessage_ShouldReturnCorrectResultWithKey_0()
        {
            //Arrange
            requestService.request.Message = "Листя опадає з дерев, а вітер підхоплює його";
            requestService.request.CaesarKey = 0;
            //Act

            var actual = requestService.GetEncryptCaesarMessage();
            var expected = "Листя опадає з дерев, а вітер підхоплює його";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetEncryptVigenereMessage_ShouldReturnCorrectResult()
        {
            //Arrange
            requestService.request.Message = "Листя опадає з дерев, а вітер підхоплює його";
            requestService.request.VigenereKey = "ключ";
            //Act

            var actual = requestService.GetEncryptVigenereMessage();
            var expected = "Лцпмйлмйлсябкхю свґь,лячнчраблндрємйьйдчшабї";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetEncryptVigenereMessage_ShouldReturnCorrectResultWithKey()
        {
            //Arrange
            requestService.request.Message = "Листя опадає з дерев, а вітер підхоплює його";
            requestService.request.VigenereKey = "к л ю ч";
            //Act

            var actual = requestService.GetEncryptVigenereMessage();
            var expected = "Лигть їаасад гкдтрґв,калвзтаб бігхїалйєюйїоо";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetEncryptAtbushMessage_ShouldReturnCorrectResult()
        {
            //Arrange
            requestService.request.Message = "Листя опадає з дерев, а вітер підхоплює його";

            //Act

            var actual = requestService.GetEncryptAtbushMessage();
            var expected = "Нсиз яйїюцюфятяцхіхщ,яюящрзхіяїрцейїмафяойшй";

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetDecryptAtbushMessage_ShouldReturnCorrectResult()
        {
            //Arrange
            requestService.request.Message = "Нсиз яйїюцюфятяцхіхщ,яюящрзхіяїрцейїмафяойшй";

            //Act

            var actual = requestService.GetDecryptAtbushMessage();
            var expected = "Листя опадає з дерев, а вітер підхоплює його";

            //Assert
            Assert.Equal(expected, actual);
        }
    }
    public class CheckerTests
    {
        Checker checker = new Checker();
        [Fact]
        public void ErrorText_ShouldReturnTextAboutError_IfKeyLenght_0()
        {
            //Arrange
            Request request = new Request();
            var key = request.VigenereKey = "";

            //Act
            var actual = checker.ErrorText(key);
            var expected = "Key can`t be empty for Caesar or Vigenere method";

            //Assert

            Assert.Equal(expected,actual);
        }
        [Fact]
        public void IsOnlyUkrainianLetters_ShouldReturnFalse_IfAnySymbolIsDigit()
        {
            //Arrange
            Request request = new Request();
            var key = request.VigenereKey = "аіві423аіваі";

            //Act
            var actual = checker.IsOnlyUkrainianLetters(key);

            //Assert

            Assert.False(actual);
        }
        [Fact]
        public void IsOnlyUkrainianLetters_ShouldReturnFalse_IfAnySymbolNotFromAlphabet()
        {
            //Arrange
            Request request = new Request();
            var key = request.VigenereKey = "КлючV";

            //Act
            var actual = checker.IsOnlyUkrainianLetters(key);

            //Assert

            Assert.False(actual);
        }
        [Fact]
        public void IsOnlyUkrainianLetters_ShouldReturnTrue_IfEverythingOk()
        {
            //Arrange
            var key = "Ключ";

            //Act
            var actual = checker.IsOnlyUkrainianLetters(key);

            //Assert

            Assert.True(actual);
        }
        [Fact]
        public void IsOnlyIntegerKey_ShouldReturnFalse_WhenAnyCharIsLetter()
        {
            //Arrange
            var key = "234q43";

            //Act
            var actual = checker.IsOnlyIntegerKey(key);

            //Assert
            Assert.False(actual);
        }
        [Fact]
        public void IsOnlyIntegerKey_ShouldReturnFalse_WhenKeyIsFloat()
        {
            //Arrange
            var key = "4,43";

            //Act
            var actual = checker.IsOnlyIntegerKey(key);

            //Assert
            Assert.False(actual);
        }
        [Fact]
        public void IsOnlyIntegerKey_ShouldReturnTrue_WhenKeyIsInteger()
        {
            //Arrange
            var key = "3";

            //Act
            var actual = checker.IsOnlyIntegerKey(key);

            //Assert
            Assert.True(actual);
        }
        [Fact]
        public void IsKeyCaesarValueIsValid_ShouldReturnFalse_WhenKeyLowerThan_0()
        {
            //Arrange
            var key = "-12";

            //Act
            var actual = checker.IsKeyCaesarValueIsValid(key);

            //Assert

            Assert.False(actual);
        }
        [Fact]
        public void IsKeyCaesarValueIsValid_ShouldReturnFalse_WhenKeyHigherThan_33()
        {
            //Arrange
            var key = "34";

            //Act
            var actual = checker.IsKeyCaesarValueIsValid(key);

            //Assert

            Assert.False(actual);
        }
        [Fact]
        public void IsKeyCaesarValueIsValid_ShouldReturnTrue_WhenKeyIsOk()
        {
            //Arrange
            var key = "33";
            var secondKey = "1";
            var thirdKey = "23";

            //Act
            var actualFirst = checker.IsKeyCaesarValueIsValid(key);
            var actualSecond = checker.IsKeyCaesarValueIsValid(secondKey);
            var actualThird = checker.IsKeyCaesarValueIsValid(thirdKey);

            //Assert

            Assert.True(actualFirst);
            Assert.True(actualSecond);
            Assert.True(actualThird);
        }

    }

}
