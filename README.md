# Sclera - Photo Gear List Engine
#### *Created by Chrishaun Byrom*
&nbsp;
[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.com/merchp/sclera.svg?branch=master)](https://travis-ci.com/github/merchp/sclera)

*Sclera is a photography gear recommendation engine for aspiring or experienced photographers.*
&nbsp;
# Table of Contents

1. **[Features](#Features)** 
2. **[Tech](#Tech)**
3. **[Requirements](Requirements)**
4. **[Database Diagram](#DatabaseDiagram)**
5. **[Wire Flow](#WireflowDraft)**
6. **[Sample Mobile App Images](#SampleMobileAppImages)**

&nbsp;

> This project is a work in progress, so don't be mad if I change stuff randomly!

&nbsp;
## Features 


- Downloadable Personalized Photography gear list
- Personalized Niche Generator
- Recommended Courses
&nbsp;
## Tech

Sclera uses a number of open source projects to work properly:

- HTML
- CSS
- React (JavaScript)
- Blazor, Razor, Xamarin (C#)
- TSQL


&nbsp;
## Requirements


###  User Story
As a photographer, I wanted to create a website that could link people’s existing passions with photography and guide them to a solution that fits within their lifestyle, budget and level of knowledge. Therefore, the Sclera recommendation engine which takes a survey of the user’s lifestyle, budget and level of knowledge and generates a visual recommendation for them to pursue their dream in photography.

## Use Case Scenario 

Given a new user, the user will be directed to a sign-in page where they will be able to sign in to the engine. When they sign up they will be able to start a survey. Then after completing the survey a visual recommendation of their photography niche and gear list will be generated.

### Use-Case Diagram (UML)

![sclera Use-Case Diagram](https://github.com/merchp/sclera/blob/3d5898ab8de35b4d9d39e15b7ddcc8f6549bf8f3/UML.png)

### Requirements 
The user will opt to sign up for an account on Sclera.
a.	The user will be asked to create an email, username, and password.
i.	The user can opt in using Facebook, Twitter, Pinterest or LinkedIn
b.	Once created, the user will verify their account credentials via verification email sent to their designated inbox.
c.	Once verified they can edit their profile.
2.	The user can then opt-in to take an assessment/survey.
a.	The questions they answer will be logged and saved.
b.	Once saved the user can generate their recommendation.
3.	The engine will deliver the user’s niche  & gear list recommendation based on the survey results



&nbsp;
## Database Diagram

![sclera database diagram](https://user-images.githubusercontent.com/46344252/108671946-1cadca00-7496-11eb-9973-67024e2a6691.JPG)

## Wireflow Draft
Here's the first implementation of the apps nooks & crannies.

![Sclera Wireflow](https://user-images.githubusercontent.com/46344252/108671452-53371500-7495-11eb-9764-6737901b3530.png)

# Sample Mobile App Images


