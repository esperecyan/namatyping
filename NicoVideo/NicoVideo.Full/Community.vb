Imports Pronama.NicoVideo.LiveStreaming
Imports Pronama.NicoVideo.LiveStreaming.CommunityChannelRoom

Public Class Community
    Inherits ChannelCommunity

    Property Level As Integer

    ''' <summary>
    ''' コミュニティレベルをもとに、作られる<see cref="CommunityChannelRoom"/>を取得します。
    ''' </summary>
    ''' <returns></returns>
    Friend Function GetCommunityChannelRooms() As CommunityChannelRoom()
        Select Case Level
            Case Is < 50
                Return {Arena, StandingA}
            Case Is < 70
                Return {Arena, StandingA, StandingB}
            Case Is < 105
                Return {Arena, StandingA, StandingB, StandingC}
            Case Is < 150
                Return {Arena, StandingA, StandingB, StandingC, StandingD}
            Case Is < 190
                Return {Arena, StandingA, StandingB, StandingC, StandingD, StandingE}
            Case Is < 230
                Return {Arena, StandingA, StandingB, StandingC, StandingD, StandingE, StandingF}
            Case Is < 256
                Return {Arena, StandingA, StandingB, StandingC, StandingD, StandingE, StandingF, StandingG}
            Case Else
                Return {Arena, StandingA, StandingB, StandingC, StandingD, StandingE, StandingF, StandingG, StandingH, StandingI}
        End Select
    End Function
End Class

