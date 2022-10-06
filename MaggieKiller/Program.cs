// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Scan for SQL Server ports open

//inventory SQL Servers detected

//scan each server that responded

//Query SQL logs for clrs that have been loaded into the engine

//Query DMVs for loaded namespaces that are not Microsoft

//list offending clr dlls

//Offer to not load the dlls as an "optimization" process

//allow for a timed window of detection and resolution, after said timed window has expired, highlight the optimization and hint at that this will help them.  

//do not force resolution, that will be too forceful and look the same as a nafriuos actor.  Help them understand and opt in.


//WT Implementation of maggie Killer:
//installer will scan the SQL instances that it is pointed at
//DotNetInstallLibrary is the most viable piece of our installation processes that could seemlessly handle this try of operation.
//Off the top of my head: 
// Update to DotNetInstallLibrary to do the SQL Server analysis and detection of bad signatured dll loading into the SQL Engine during initialition.
//Action to be taken upon detection -- block that dectected dll from loadin into SQL, instead load our own version, that will log the accesses to the updated dll and dump activity to a local log file.
//this version will look like theirs but not have any possibly nafarious actions exposed.  instead, it will log their information and what they tried to do.  this should stream to the FBI-- but that is too detectable.  
//The point is that their own servers will be poisined and they won't know which ones are comprimised, should make them shut down out of self preservation.


