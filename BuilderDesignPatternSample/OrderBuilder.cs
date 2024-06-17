namespace BuilderDesignPatternSample
{
    public class OrderBuilder
    {
        private int _number;
        private DateTime _createdOn;
        private readonly AddressBuilder _addressBuilder = AddressBuilder.Empty();
        public OrderBuilder()
        {

        }

        public static OrderBuilder Empty() => new();

        public OrderBuilder WithNumber(int number)
        {
            _number = number;
            return this;
        }
        public OrderBuilder WithCreatedOn(DateTime createdOn)
        {
            _createdOn = createdOn;
            return this;
        }

        public OrderBuilder WithAddress(Action<AddressBuilder> action)
        {
            action(_addressBuilder);
            return this;
        }

        public Order Build() => new Order
        {
            Number = _number,
            CreatedOn = _createdOn,
            Address = _addressBuilder.Build()
        };
    }

    public class AddressBuilder
    {
        private string _street;
        private string _city;
        private string _postalCode;
        private string _state;
        private string _country;
        public AddressBuilder()
        {

        }

        public static AddressBuilder Empty() => new();

        public AddressBuilder Street(string street)
        {
            _street = street;
            return this;
        }
        public AddressBuilder City(string city)
        {
            _city = city;
            return this;
        }
        public AddressBuilder PostalCode(string postalCode)
        {
            _postalCode = postalCode;
            return this;
        }
        public AddressBuilder State(string state)
        {
            _state = state;
            return this;
        }
        public AddressBuilder Country(string country)
        {
            _country = country;
            return this;
        }

        public Address Build() => new Address
        {
            City = _city,
            Country = _country,
            PostalCode = _postalCode,
            State = _state ?? "N/A",
            Street = _street
        };
    }
}
