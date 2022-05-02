set VSTEST="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console"
set MSTEST_Framework="msTest"
set XUNIT_Framework="xUnit"
set NUNIT_Framework="nUnit"
set msUnitTest=".\WpfApp.%MSTEST_Framework%\bin\Debug\netcoreapp3.1\WpfApp.%MSTEST_Framework%.dll"
set xUnitTest=".\WpfApp.Test.%XUNIT_Framework%\bin\Debug\netcoreapp3.1\WpfApp.Test.%XUNIT_Framework%.dll"
set nUnitTest=".\WpfApp.Test.%NUNIT_Framework%\bin\Debug\netcoreapp3.1\WpfApp.Test.%NUNIT_Framework%.dll"

%VSTEST% %msUnitTest%
%VSTEST% %xUnitTest%
%VSTEST% %nUnitTest%
