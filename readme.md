# Implementation of Primary Ports

## [ICreditController.cs](./Day13HexArchExercise/Primary/Interfaces/ICreditController.cs)

> Credit listing and be able to check if customer have enough for a given amount.

## [IPortabilityController.cs](./Day13HexArchExercise/Primary/Interfaces/IPortabilityController.cs)

> For portability credit requests from an individual or an external financial entity.


# Implementation of Primary Adapters

## [ExternalPortabilityController.cs](./Day13HexArchExercise/Primary/Adapters/ExternalPortabilityController.cs)

## [HttpController.cs](./Day13HexArchExercise/Primary/Adapters/HttpController.cs)

## [PersonalPortabilityController.cs](./Day13HexArchExercise/Primary/Adapters/PersonalPortabilityController.cs)

## [RestApiController.cs](./Day13HexArchExercise/Primary/Adapters/RestApiController.cs)

---
---

# Implementation of Secondary Ports

## [ICreditRepository.cs](./Day13Hexercise/Secondary/Interfaces/ICreditRepository.cs)

> For storing and retrieving credit information from either a SQL or NoSQL databases.

## [IInfoRequester.cs](./Day13Hexercise/Secondary/Interfaces/IInfoRequester.cs)

> For requesting information from internal and external entities.


# Implementation of Secondary Adapters

## [ExternalInfoRequester.cs](./Day13Hexercise/Secondary/Adapters/ExternalInfoRequester.cs)

## [InternalInfoRequester.cs](./Day13Hexercise/Secondary/Adapters/InternalInfoRequester.cs)

## [NoSqlCreditRepository.cs](./Day13Hexercise/Secondary/Adapters/NoSqlCreditRepository.cs)

## [SqlCreditRepository.cs](./Day13Hexercise/Secondary/Adapters/SqlCreditRepository.cs)
