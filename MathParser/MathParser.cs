using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParser
{
    public class MathParser
    {
        private string? _text;
        private int _pos;

        public double Evaluate(string input)
        {
            _text = input.Replace(" ", "");
            _pos = 0;
            var result = ParseExpression();
            if (_pos < _text.Length)
                throw new Exception("Unexpected characters at end of expression");
            return result;
        }

        private double ParseExpression()
        {
            double x = ParseTerm();
            while (_pos < _text!.Length)
            {
                char op = _text[_pos];
                if (op == '+' || op == '-')
                {
                    _pos++;
                    double y = ParseTerm();
                    x = (op == '+') ? x + y : x - y;
                }
                else break;
            }
            return x;
        }

        private double ParseTerm()
        {
            double x = ParseFactor();
            while (_pos < _text!.Length)
            {
                char op = _text[_pos];
                if (op == '*' || op == '/')
                {
                    _pos++;
                    double y = ParseFactor();
                    x = (op == '*') ? x * y : x / y;
                }
                else break;
            }
            return x;
        }

        private double ParseFactor()
        {
            if (Match("sqrt"))
            {
                Expect('(');
                double value = ParseExpression();
                Expect(')');
                return Math.Sqrt(value);
            }

            if (Match("("))
            {
                double value = ParseExpression();
                Expect(')');
                return value;
            }

            return ParseNumber();
        }

        private double ParseNumber()
        {
            int start = _pos;
            while (_pos < _text!.Length &&
                   (char.IsDigit(_text[_pos]) || _text[_pos] == '.'))
            {
                _pos++;
            }

            string substr = _text.Substring(start, _pos - start);
            if (!double.TryParse(substr, NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
                throw new Exception($"Invalid number: '{substr}'");
            return result;
        }

        private void Expect(char expected)
        {
            if (_pos >= _text!.Length || _text[_pos] != expected)
                throw new Exception($"Expected '{expected}' at position {_pos}");
            _pos++;
        }

        private bool Match(string keyword)
        {
            if (_text![_pos..].StartsWith(keyword))
            {
                _pos += keyword.Length;
                return true;
            }
            return false;
        }
    }
}
