csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    JumpingSums.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
del *.exe