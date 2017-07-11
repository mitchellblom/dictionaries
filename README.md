# NSS Dictionaries Exercise

A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

1. Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

1. Define a new Dictionary to hold the aggregated purchase information.
- The key should be a string that is the full company name.
- The value will be the valuation of each stock (price*amount)

1. Iterate over the purchases and 
 - If the company name key already exists in the report dictionary, update the total valuation
 - If not, add the new key and set its value