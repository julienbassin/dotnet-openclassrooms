function Get-COnnectionSQL {
    [CmdletBinding(DefaultParameterSetName="Windows Authentication")]
    param (
        [Parameter(ParameterSetName="Windows Authentication")]
        [Parameter(ParameterSetName="SQL authentication")]
        [string]$Connection
    )

    begin {
        $hashtable =@{
            displayname = "toto"
            givenName = "test"
        }
    }

    process {

    }

    end {

    }
}