﻿using System;

namespace OneOf
{
    public struct OneOf<T0> : IOneOf
    {
        private readonly T0 _value0;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0))
        {
            _value0 = value0;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0> (T0 t)
            => new OneOf<T0>(0, value0: t);

        public void Switch(Action<T0> f0)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0> && Equals((OneOf<T0>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0> : IOneOf
    where T0 : class
    {
        private readonly T0 _value0;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0))
        {
            _value0 = value0;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0> (T0 t)
            => new OneOfBase<T0>(0, value0: t);

        public void Switch(Action<T0> f0)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
        }

        private bool Equals(OneOfBase<T0> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1))
        {
            _value0 = value0;
            _value1 = value1;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1> (T0 t)
            => new OneOf<T0, T1>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1> (T1 t)
            => new OneOf<T0, T1>(1, value1: t);

        public void Switch(Action<T0> f0, Action<T1> f1)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1> && Equals((OneOf<T0, T1>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1> : IOneOf
    where T0 : class
    where T1 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1))
        {
            _value0 = value0;
            _value1 = value1;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1> (T0 t)
            => new OneOfBase<T0, T1>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1> (T1 t)
            => new OneOfBase<T0, T1>(1, value1: t);

        public void Switch(Action<T0> f0, Action<T1> f1)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
        }

        private bool Equals(OneOfBase<T0, T1> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2> (T0 t)
            => new OneOf<T0, T1, T2>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2> (T1 t)
            => new OneOf<T0, T1, T2>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2> (T2 t)
            => new OneOf<T0, T1, T2>(2, value2: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2> && Equals((OneOf<T0, T1, T2>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2> (T0 t)
            => new OneOfBase<T0, T1, T2>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2> (T1 t)
            => new OneOfBase<T0, T1, T2>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2> (T2 t)
            => new OneOfBase<T0, T1, T2>(2, value2: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2, T3> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2, T3> (T0 t)
            => new OneOf<T0, T1, T2, T3>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2, T3> (T1 t)
            => new OneOf<T0, T1, T2, T3>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2, T3> (T2 t)
            => new OneOf<T0, T1, T2, T3>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOf<T0, T1, T2, T3> (T3 t)
            => new OneOf<T0, T1, T2, T3>(3, value3: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2, T3> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3> && Equals((OneOf<T0, T1, T2, T3>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    where T3 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2, T3> (T0 t)
            => new OneOfBase<T0, T1, T2, T3>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2, T3> (T1 t)
            => new OneOfBase<T0, T1, T2, T3>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2, T3> (T2 t)
            => new OneOfBase<T0, T1, T2, T3>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOfBase<T0, T1, T2, T3> (T3 t)
            => new OneOfBase<T0, T1, T2, T3>(3, value3: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
            var value3 = this as T3;
            if (value3 != null)
            {
                _index = 3;
                _value3 = value3;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2, T3> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2, T3, T4> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T0 t)
            => new OneOf<T0, T1, T2, T3, T4>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T1 t)
            => new OneOf<T0, T1, T2, T3, T4>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T2 t)
            => new OneOf<T0, T1, T2, T3, T4>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T3 t)
            => new OneOf<T0, T1, T2, T3, T4>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T4 t)
            => new OneOf<T0, T1, T2, T3, T4>(4, value4: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2, T3, T4> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4> && Equals((OneOf<T0, T1, T2, T3, T4>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T0 t)
            => new OneOfBase<T0, T1, T2, T3, T4>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T1 t)
            => new OneOfBase<T0, T1, T2, T3, T4>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T2 t)
            => new OneOfBase<T0, T1, T2, T3, T4>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T3 t)
            => new OneOfBase<T0, T1, T2, T3, T4>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T4 t)
            => new OneOfBase<T0, T1, T2, T3, T4>(4, value4: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
            var value3 = this as T3;
            if (value3 != null)
            {
                _index = 3;
                _value3 = value3;
            }
            var value4 = this as T4;
            if (value4 != null)
            {
                _index = 4;
                _value4 = value4;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2, T3, T4> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2, T3, T4, T5> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T0 t)
            => new OneOf<T0, T1, T2, T3, T4, T5>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T1 t)
            => new OneOf<T0, T1, T2, T3, T4, T5>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T2 t)
            => new OneOf<T0, T1, T2, T3, T4, T5>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T3 t)
            => new OneOf<T0, T1, T2, T3, T4, T5>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T4 t)
            => new OneOf<T0, T1, T2, T3, T4, T5>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T5 t)
            => new OneOf<T0, T1, T2, T3, T4, T5>(5, value5: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2, T3, T4, T5> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5> && Equals((OneOf<T0, T1, T2, T3, T4, T5>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T0 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T1 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T2 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T3 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T4 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T5 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5>(5, value5: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
            var value3 = this as T3;
            if (value3 != null)
            {
                _index = 3;
                _value3 = value3;
            }
            var value4 = this as T4;
            if (value4 != null)
            {
                _index = 4;
                _value4 = value4;
            }
            var value5 = this as T5;
            if (value5 != null)
            {
                _index = 5;
                _value5 = value5;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2, T3, T4, T5, T6> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly T6 _value6;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T0 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T1 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T2 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T3 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T4 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T5 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(5, value5: t);

        public bool IsT6
            => _index == 6;

        public T6 AsT6
            => _value6;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T6 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6>(6, value6: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            if (IsT6 && f6 != null)
            {
                f6(_value6);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
    where T6 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly T6 _value6;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T0 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T1 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T2 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T3 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T4 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T5 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(5, value5: t);

        public bool IsT6
            => _index == 6;

        public T6 AsT6
            => _value6;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T6 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(6, value6: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            if (IsT6 && f6 != null)
            {
                f6(_value6);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
            var value3 = this as T3;
            if (value3 != null)
            {
                _index = 3;
                _value3 = value3;
            }
            var value4 = this as T4;
            if (value4 != null)
            {
                _index = 4;
                _value4 = value4;
            }
            var value5 = this as T5;
            if (value5 != null)
            {
                _index = 5;
                _value5 = value5;
            }
            var value6 = this as T6;
            if (value6 != null)
            {
                _index = 6;
                _value6 = value6;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly T6 _value6;
        private readonly T7 _value7;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T0 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T1 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T2 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T3 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T4 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T5 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);

        public bool IsT6
            => _index == 6;

        public T6 AsT6
            => _value6;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T6 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);

        public bool IsT7
            => _index == 7;

        public T7 AsT7
            => _value7;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T7 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            if (IsT6 && f6 != null)
            {
                f6(_value6);
                return;
            }

            if (IsT7 && f7 != null)
            {
                f7(_value7);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6.GetHashCode();
                        break;
                    case 7:
                        hashCode = _value7.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
    where T6 : class
    where T7 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly T6 _value6;
        private readonly T7 _value7;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T0 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T1 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T2 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T3 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T4 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T5 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);

        public bool IsT6
            => _index == 6;

        public T6 AsT6
            => _value6;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T6 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);

        public bool IsT7
            => _index == 7;

        public T7 AsT7
            => _value7;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T7 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            if (IsT6 && f6 != null)
            {
                f6(_value6);
                return;
            }

            if (IsT7 && f7 != null)
            {
                f7(_value7);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
            var value3 = this as T3;
            if (value3 != null)
            {
                _index = 3;
                _value3 = value3;
            }
            var value4 = this as T4;
            if (value4 != null)
            {
                _index = 4;
                _value4 = value4;
            }
            var value5 = this as T5;
            if (value5 != null)
            {
                _index = 5;
                _value5 = value5;
            }
            var value6 = this as T6;
            if (value6 != null)
            {
                _index = 6;
                _value6 = value6;
            }
            var value7 = this as T7;
            if (value7 != null)
            {
                _index = 7;
                _value7 = value7;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6.GetHashCode();
                        break;
                    case 7:
                        hashCode = _value7.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly T6 _value6;
        private readonly T7 _value7;
        private readonly T8 _value8;
        private readonly int _index;

        private OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _value8 = value8;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T0 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T1 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T2 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T3 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T4 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T5 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);

        public bool IsT6
            => _index == 6;

        public T6 AsT6
            => _value6;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T6 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);

        public bool IsT7
            => _index == 7;

        public T7 AsT7
            => _value7;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T7 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);

        public bool IsT8
            => _index == 8;

        public T8 AsT8
            => _value8;

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T8 t)
            => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(8, value8: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            if (IsT6 && f6 != null)
            {
                f6(_value6);
                return;
            }

            if (IsT7 && f7 != null)
            {
                f7(_value7);
                return;
            }

            if (IsT8 && f8 != null)
            {
                f8(_value8);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            if (IsT8 && f8 != null)
            {
                return f8(_value8);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            if (IsT8 && f8 != null)
            {
                return f8(_value8);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        private bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6.GetHashCode();
                        break;
                    case 7:
                        hashCode = _value7.GetHashCode();
                        break;
                    case 8:
                        hashCode = _value8.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf
    where T0 : class
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
    where T6 : class
    where T7 : class
    where T8 : class
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;
        private readonly T4 _value4;
        private readonly T5 _value5;
        private readonly T6 _value6;
        private readonly T7 _value7;
        private readonly T8 _value8;
        private readonly int _index;

        private OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8))
        {
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _value8 = value8;
            _index = index;
        }

        object IOneOf.Value
        {
            get
            {
                switch(_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
            => _index == 0;

        public T0 AsT0
            => _value0;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T0 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);

        public bool IsT1
            => _index == 1;

        public T1 AsT1
            => _value1;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T1 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);

        public bool IsT2
            => _index == 2;

        public T2 AsT2
            => _value2;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T2 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);

        public bool IsT3
            => _index == 3;

        public T3 AsT3
            => _value3;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T3 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);

        public bool IsT4
            => _index == 4;

        public T4 AsT4
            => _value4;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T4 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);

        public bool IsT5
            => _index == 5;

        public T5 AsT5
            => _value5;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T5 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);

        public bool IsT6
            => _index == 6;

        public T6 AsT6
            => _value6;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T6 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);

        public bool IsT7
            => _index == 7;

        public T7 AsT7
            => _value7;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T7 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);

        public bool IsT8
            => _index == 8;

        public T8 AsT8
            => _value8;

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T8 t)
            => new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(8, value8: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
        {
            if (IsT0 && f0 != null)
            {
                f0(_value0);
                return;
            }

            if (IsT1 && f1 != null)
            {
                f1(_value1);
                return;
            }

            if (IsT2 && f2 != null)
            {
                f2(_value2);
                return;
            }

            if (IsT3 && f3 != null)
            {
                f3(_value3);
                return;
            }

            if (IsT4 && f4 != null)
            {
                f4(_value4);
                return;
            }

            if (IsT5 && f5 != null)
            {
                f5(_value5);
                return;
            }

            if (IsT6 && f6 != null)
            {
                f6(_value6);
                return;
            }

            if (IsT7 && f7 != null)
            {
                f7(_value7);
                return;
            }

            if (IsT8 && f8 != null)
            {
                f8(_value8);
                return;
            }

            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            if (IsT8 && f8 != null)
            {
                return f8(_value8);
            }

            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(_value0);
            }

            if (IsT1 && f1 != null)
            {
                return f1(_value1);
            }

            if (IsT2 && f2 != null)
            {
                return f2(_value2);
            }

            if (IsT3 && f3 != null)
            {
                return f3(_value3);
            }

            if (IsT4 && f4 != null)
            {
                return f4(_value4);
            }

            if (IsT5 && f5 != null)
            {
                return f5(_value5);
            }

            if (IsT6 && f6 != null)
            {
                return f6(_value6);
            }

            if (IsT7 && f7 != null)
            {
                return f7(_value7);
            }

            if (IsT8 && f8 != null)
            {
                return f8(_value8);
            }

            if (otherwise != null)
            {
                return otherwise();
            }

            throw new InvalidOperationException();
        }

        protected OneOfBase()
        {
            var value0 = this as T0;
            if (value0 != null)
            {
                _index = 0;
                _value0 = value0;
            }
            var value1 = this as T1;
            if (value1 != null)
            {
                _index = 1;
                _value1 = value1;
            }
            var value2 = this as T2;
            if (value2 != null)
            {
                _index = 2;
                _value2 = value2;
            }
            var value3 = this as T3;
            if (value3 != null)
            {
                _index = 3;
                _value3 = value3;
            }
            var value4 = this as T4;
            if (value4 != null)
            {
                _index = 4;
                _value4 = value4;
            }
            var value5 = this as T5;
            if (value5 != null)
            {
                _index = 5;
                _value5 = value5;
            }
            var value6 = this as T6;
            if (value6 != null)
            {
                _index = 6;
                _value6 = value6;
            }
            var value7 = this as T7;
            if (value7 != null)
            {
                _index = 7;
                _value7 = value7;
            }
            var value8 = this as T8;
            if (value8 != null)
            {
                _index = 8;
                _value8 = value8;
            }
        }

        private bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            if(_index != other._index)
            {
                return false;
            }
            switch(_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch(_index)
                {
                    case 0:
                        hashCode = _value0.GetHashCode();
                        break;
                    case 1:
                        hashCode = _value1.GetHashCode();
                        break;
                    case 2:
                        hashCode = _value2.GetHashCode();
                        break;
                    case 3:
                        hashCode = _value3.GetHashCode();
                        break;
                    case 4:
                        hashCode = _value4.GetHashCode();
                        break;
                    case 5:
                        hashCode = _value5.GetHashCode();
                        break;
                    case 6:
                        hashCode = _value6.GetHashCode();
                        break;
                    case 7:
                        hashCode = _value7.GetHashCode();
                        break;
                    case 8:
                        hashCode = _value8.GetHashCode();
                        break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

}
