# Dillinger

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

We have created Shortest Job First Scheduling Algorithm Simulator using C# Language. Shortest Job algorithm is a scheduling policy that selects for execution the waiting process with the smallest execution time. The SJF algorithm favors short jobs (or processors) at the expense of longer ones. Our algorithm is non pre-emptive and Processor should know the execution time before executing it.

# Inputs
User Should Provide the Given information as a Table
- Process Name
-  Arrival Time
- Execution Time


We are taking the process name, process burst time and arrival time in a Data Grid View. Then we sort according to the arrival time. We used a global variable - currentRunningTime to indicate the process running time. If there is no process at the currentRunningTime=0, then we add one until it takes 1st process’s arrival time. e check every unit time whether there is a process available at the DataGridView if available we add it to another Data Grid View called process stack and every time we take any process execute we sort the process stack according to the arrival time and put in to execution. Before each process started to execute we calculate burst time by educting arrival time from currentrunningtime and added to another aiting time list.

![](http://4.bp.blogspot.com/-dAlfXVeCBAU/XJR9u99Ct8I/AAAAAAAAKY4/R6b5I10OTrkyJvRE9ugWGtMnphYR_8YKgCK4BGAYYCw/s640/Screenshot%2Bfrom%2B2019-03-22%2B11-42-56.png)

This text you see here is *actually* written in Markdown! To get a feel for Markdown's syntax, type some text into the left window and watch the results in the right.

![](http://4.bp.blogspot.com/-dAlfXVeCBAU/XJR9u99Ct8I/AAAAAAAAKY4/R6b5I10OTrkyJvRE9ugWGtMnphYR_8YKgCK4BGAYYCw/s640/Screenshot%2Bfrom%2B2019-03-22%2B11-42-56.png)

### Dashboard
![](http://1.bp.blogspot.com/-OBUGXAVpmss/XJR9691TVmI/AAAAAAAAKZI/wI12xaVx_3kC9x-rI8rPSBOg65_VPXG-wCK4BGAYYCw/s400/Screenshot%2Bfrom%2B2019-03-22%2B11-42-48.png)

### Results
![](http://2.bp.blogspot.com/-ECyghdZ5YKI/XJR9wNBXKzI/AAAAAAAAKZA/1Uo8m9bTsGobtwmcLmUGEMJvd0U9LtNzgCK4BGAYYCw/s400/Screenshot%2Bfrom%2B2019-03-22%2B11-43-02.png)



