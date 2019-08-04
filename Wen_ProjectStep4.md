
## Feature: Display of goods
Only store owners can post new products, delete or edit information about existng products, except site manager, who can delete any product in all stores. 

### Background:
	Given a global site manager named "King"
	And a store named "Elechomes"
	And a customer named "Will"
	And a store named "Blue Square" owned by "Will"
	
### Scenario: Will posts a new product to his own store
	Given I am logged in as Will
	When I try to  post to Blue Square
	Then I should see "Your product is now online"
	
### Scenario: Will tries to post a new product to someone else's store and fails
	Given I am logged in as Will
	When I try to  post to Elechomes
	Then I should see "Hey! This is not your store"
	
### Scenario: King deletes a product from a client's store
	Given I am logged in as King
	When I try to delete a product from Elechomes
	Then I should see "Product deleted"
	
### Scenario: Will looks at a product
	Given I am logged in as Will
	When I clicked on the picture of a product
	Then I should see more pictures, the price and detailed description about the product



## Feature: A payment module
Customers can only pay with credit/debit cards or gift cards

### Background:
	Given a customer named "Will"
	And a product named "Book"
	
### Scenario: Will pays for a product 
	Given I am logged in as Will
	When I try to pay for Book using a credit/debit card
	Then I should see "Order Placed"
	
### Scenario: Will pays for a product 
	Given I am logged in as Will
	When I try to pay for Book using a gift card
	Then I should see "Order Placed"
	
### Scenario: Will pays for a product 
	Given I am logged in as Will
	When I try to pay for Book using cash
	Then I should not be able to pay




## Feature: An inventory control mechanism
Only store owners can set the quanity limit of their own products, when quanity is zero product will be unavaliable 

### Background: 
	Given a customer named "Will"
	And a customer named "Bunn"
	And a store named "Blue Square" owned by "Will"
	
### Scenario: Will posts a new product	
	Given I am logged in as Will
	When I try to post a new product
	Then I should see a section called quanity
	
### Scenario: Bunn purchases a product
	Given I am Logged in as Bunn
	When I try to purchase a product with zero quanity in stock
	Then I should see "This product is currently unavaliable"