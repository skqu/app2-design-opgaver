```mermaid
stateDiagram
    GuiLogin --> LoggingIn: Login handler
    LoggingIn --> GuiSystem: Login handler success
    LoggingIn --> GuiLogin: Login handler failure
    GuiSystem --> SystemHandling: Gui interaction
    SystemHandling --> RPI: Systemhandler success
    SystemHandling --> GuiSystem: Systemhandler failure
    RPI --> API: API request
    API --> SystemDBMS: API success
    API --> RPI: API failure
    SystemDBMS --> SystemHandling: DBMS success
    SystemDBMS --> RPI: DBMS failure

