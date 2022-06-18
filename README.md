# Finances extended

Finances extended is a extended poc of the another poc "Finances"  for understanding how to use classes within classes. 

## Installation

You may install this project by cloning this repository from GitHub 

## Usage

### Case description 

Remember we had an assignment about a wallet? A wallet belongs to a person, so in the class Wallet we 
had a field to store the owner’s name. In real life there should be much more fields in it. In this 
assignment, it is about a person with two wallets. If we stick to the former implementation of the class 
Wallet, we have the information of the owner in each wallet-object. That’s not a good design. We will 
update the application to provide options for 2 wallets. 
 
* Problem: in the Form we have a variable of type Person, but the 2 wallets of the person are private. How 
can we display information of such a private wallet on the screen? 
* Hint: have a public method in the class Person that returns a Wallet.  
