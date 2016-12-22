﻿Public Class Prophecy
    Public UName As String
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CardDraw1, CardDraw2, CardDraw3 As New Integer
        Dim Randomizer As New Random
        Dim Prophecies As Array
        Prophecies = {"The fool advises you to release any demands or expectations. Give your complete attention to events as they are occurring in the present moment.", "The magus advises you to respond in a spontaneous manner to what is right in front of you. There is no reason to hold yourself back. Your natural urges are exactly what is needed, and, your ingenuous timing and elegant style will help smooth over any awkwardness.", "The priestess advises you that a spiritual routine that suits your temperament, practiced every day, is the most trustworthy path to freedom.", "The priestess advises you to demonstrate through caring actions, a forgiving and generous attitude, and wise understanding of others' needs and struggles. Bring a healing influence to the current situation and take full credit for the supportive part you play.", "The Emperor suggests that you have the necessary abilities to be the final authority. This situation is an opportunity to showcase your competence and skill. Act with the confidence of someone who knows how to take care of business.", "The hierophant suggests that you will earn respect and recognition by completing your education and broadening your experience. If you already have all the necessary experience you need, then rewrite your resume so others can appreciate who you are and what you can bring to a situation. Focus on your goal and be determined. You may be destined to be a master in your realm.", "The lovers suggets you must be willing to make some compromises, then stick with the commitments you finally make. Trust your intuition along with your rational intellect, and once you make your choice, carry it out with conviction.", "The chariot symbolizes the need to be prepared and self-contained for the changes that will sweep in and carry you with them.", "The strength means you need to demand more and expect the same from others who have some power in this situation. You cannot challenge them to live to a higher standard if you, yourself, have not yet done so. Influence others by setting an example of integrity. Your self-esteem will increase to the degree that you succeed in your efforts.", "The Hermit tells you that now may be the moment for you to tell everyone to leave you alone. When you are fully ready, you will be able and willing to give others what they need.", "The Fortune reassures you,this is a safe place for you to be. You are watched over and protected as you go round and round the wheel. You will learn a lot. You will also learn it quickly, and what you absorb will benefit you for a long time to come.", "The Justice means that as you witness people's account of themselves, your understanding will go beyond the words you hear. Subtle inferences and clues will reveal the truths that will enable you to make a wise and accurate assessment.", "The Hanged Man advises to stop resisting your circumstances and let some time go by. Eventually, you will be released a little wiser and not much the worse for wear. You will come to realize in time how you collaborated with the problem. However, the issues you were stuck on when you were first hung up have subsided and no longer concern you. You are free to take up new endeavors. You will ultimately feel refreshed and grateful that you were derailed from your former track.", "The Death card advises you to detach from the old order. You may want to close accounts, complete unfinished tasks, and gather your harvest. It is time to move on. If you cut the cords that have bound you to old ways and outdated conventions, you could free yourself to join the sweep of incoming light. This is not an excuse to reject others or hurt them in any way. It is simply a time to move toward your ultimate interests.", "The Temperance card advises you to identify and seek the missing ingredients in your life. Marshal your known skills and abilities and do what needs to be done to complete your mission.", "The Devil card advises that you show some spunk. There may be nothing to be gained by trying to be subtle or strategic in this situation. Assert your agenda, express yourself honestly, and let the chips fall where they may. Your best bet could be to express your true emotions, possibly even including anger. Acknowledge that you have whatever feelings you have. While it may not be necessary to act out what you feel in every situation, accepting the power and depth of your inner experience enables you to remain true to yourself.", "The Tower advises you that now you may be at the forefront, acknowledging and accepting the bracing presence of the future bursting in on the present. Try to mediate the harsher parts of the changes as they unfold, so the most vulnerable are the most cushioned. Acknowledge yourself, as well as the others in your life, who are offering their resources to usher in a better future.", "The Star shows you this is a period for quiet contemplation. Listen for the voice within. Anything that would interfere with this communion may not be serving your best interests right now.", "The Moon card advises that you trust your instincts and intuitions. Your aboriginal body, which is connected to all living things, is sharper and quicker than the cultivated, civilized self. The everyday mind may not be prepared for strange oceanic circumstances. Plus, it has no game plan. Your intuitive body will support you unerringly if you do not interfere with or try to control what you perceive. A better approach would be to meditate. Try to just be a witness. Do nothing; let nature carry you forward. This may be your best option in this situation.", "The Sun card advises you to have confidence in your natural divinity. Throw off any cultural conditioning that keeps you from being authentic with yourself. Step into the full light of truth and reveal your motives and principles. Once done, you will no longer give away power to the people that criticize and shame you. Focus on the positive and the real. Your authentic shining self can be a light for others if you project it without contrivance.", "The Judgment card advises that you allow yourself to grow, transform, and release hidden potentials within yourself. Divest yourself of fruitless endeavors without neglecting your duties. At the same time, invest your energies in new growth.", "The World card may be giving you permission to do whatever you want. Presently, your motivation is close to the will of the divine. Even if you commit an error, it will be turned to the greater good. Stay active and just keep moving forward. It is unnecessary to keep checking or interrupting your spontaneity with calculation. Rather than look for consensus or affirmation from others, simply dance the dance. In other words, express yourself, react naturally, and let the chips fall where they may."}
        CardDraw1 = Randomizer.Next(0, 21)
        LeftCard.BackgroundImage = My.Resources.ResourceManager.GetObject("Card" & CardDraw1.ToString)
        Do
            CardDraw2 = Randomizer.Next(0, 21)
        Loop Until (CardDraw2 <> CardDraw1)
        MiddleCard.BackgroundImage = My.Resources.ResourceManager.GetObject("Card" & CardDraw2.ToString)
        Do
            CardDraw3 = Randomizer.Next(0, 21)
        Loop Until (CardDraw3 <> CardDraw1 And CardDraw3 <> CardDraw2)
        RightCard.BackgroundImage = My.Resources.ResourceManager.GetObject("Card" & CardDraw3.ToString)
        ProphecyBox.Text = UName + " the cards have been drawn and their divination for you is as follows." + Prophecies(CardDraw1) + Prophecies(CardDraw2) + Prophecies(CardDraw2)
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        NameSet.Show()
        Me.Close()
    End Sub
End Class