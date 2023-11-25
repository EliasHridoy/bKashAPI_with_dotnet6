

# [bKash Documentation Guideline](https://developer.bka.sh/docs/product-overview) 

## Tools and Technologies 
- .Net 6 
- RestSharpe (Library: for calling bKash API from our API)  


### Integration Stage
> 1. [Sandbox 1](/bKash-Integration-Process#Sandbox-1-Guideline)
> 1. [Sandbox 2](/bKash-Integration-Process#Sandbox-2-Guideline)
> 1. [Live Environment](/bKash-Integration-Process#Live-Environment-Guideline)

## Sandbox 1 Guideline
---
**_bKash_** shared the working process over the mail. Also provide the sandbox 1 credential for testing.

 We need to develop our backend according to their [API format](https://developer.bka.sh/reference/gettokenusingpost). 

### API Request/Response:

> Please share formal sandbox test request of each below APIs in text format so that we can validate [bKash requirment]

1. [Grant Token](https://developer.bka.sh/v1.2.0-beta/reference#gettokenusingpost)
1. [Create Payment](https://developer.bka.sh/v1.2.0-beta/reference#createpaymentusingpost)
1. [Execute Payment](https://developer.bka.sh/v1.2.0-beta/reference#executepaymentusingpost)
1. [Query Payment](https://developer.bka.sh/v1.2.0-beta/reference#querypaymentusingget (Mandatory))
1. [Search Transaction Details](https://developer.bka.sh/v1.2.0-beta/reference#searchtransactionusingget)
1. [Refund Transaction](https://developer.bka.sh/docs/refund-transaction)
1. [Refund Status](https://developer.bka.sh/docs/refund-status (Mandatory))

 Note: please use the same payment ID to call Create, Execute and Query payment API

 Please maintain following format to share the responses  –

1.        API Title :
1.        API URL :
1.        Request Body :
1.        API Response :

Error Code Implementation :

You have to  implement all the error messages according to the [error codes](https://developer.bka.sh/docs/error-codes ) so that customer gets a clear message and perform following tasks for validation  

    > You have to perform two transactions within 2min duration, with the same amount. In 2nd transaction you will get an error message.

    > You need to initiate a transaction and put wrong/invalid OTP three times deliberately. In response you will get an error message.

 After performing the above two tasks please share the following for both tasks –

1.            Invoice number of each transaction.

2.            Payment ID of each transaction.

3.            Timestamp of each transaction.

4.            Screenshot of error messages.

## Sandbox 2 Guideline
----
After successfully submitting the Sandbox 1 response as bKash describes, they will provide us the bKash Portal information. We need the register bKash portal. They shared a **_PDF_** file for the whole process.
 In bKash portal we get Sandbox-2 credentials. We created a payment and executed the payment. And share the response in bKash portal => Sandbox Validation page.


## Live Environment Guideline
---
After Validation is completed and We pass the validation, we will get the Live credential. And We can make transaction using these. 

# Developer's Note:
___
There is two way we can handle our payment process.
>> Tokenized Checkout (Need OTP verification for each transaction)
>> Agreement Base Checkout (OTP first time and we need to store Agreement Id for rest of transaction)


## Grant Token
![image](https://github.com/EliasHridoy/bKash_API_dotNet/assets/37788485/8e2f211b-7e83-4cf7-ad72-73057ab26ca5)

## Create Payment
![image](https://github.com/EliasHridoy/bKash_API_dotNet/assets/37788485/bd6e38c3-00fd-492c-922f-a67551eec4cd)

Other endpoint need to develop using this technique. Hope that will help you
