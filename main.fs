#r "nuget: FsLexYacc, 10.2.0"
#load "Absyn.fs" "CPar.fs" "CLex.fs" "Parse.fs" "ParseAndRun.fs";;

open ParseAndRun

let ast = fromFile "ex1.c"
run ast [4]



