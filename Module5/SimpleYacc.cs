// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.0
// Machine:  MIL8A-202A-02
// DateTime: 20.12.2019 19:15:50
// UserName: user
// Input file <SimpleYacc.y - 20.12.2019 18:50:40>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace SimpleParser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,CYCLE=5,INUM=6,
    RNUM=7,ID=8,ASSIGN=9,SEMICOLON=10,FOR=11,TO=12,
    DO=13};

// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<int,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
public class ScanObj {
  public int token;
  public int yylval;
  public LexLocation yylloc;
  public ScanObj( int t, int val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

public class Parser: ShiftReduceParser<int, LexLocation>
{
  // Verbatim content from SimpleYacc.y - 20.12.2019 18:50:40
// Ýòè îáúÿâëåíèÿ äîáàâëÿþòñÿ â êëàññ GPPGParser, ïðåäñòàâëÿþùèé ñîáîé ïàðñåð, ãåíåðèðóåìûé ñèñòåìîé gppg
    public Parser(AbstractScanner<int, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from SimpleYacc.y - 20.12.2019 18:50:40

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[16];
  private static State[] states = new State[29];
  private static string[] nonTerms = new string[] {
      "progr", "$accept", "block", "stlist", "statement", "assign", "cycle", 
      "for", "ident", "expr", };

  static Parser() {
    states[0] = new State(new int[]{3,4},new int[]{-1,1,-3,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{8,14,3,4,5,18,11,22},new int[]{-4,5,-5,28,-6,9,-9,10,-3,16,-7,17,-8,21});
    states[5] = new State(new int[]{4,6,10,7});
    states[6] = new State(-13);
    states[7] = new State(new int[]{8,14,3,4,5,18,11,22},new int[]{-5,8,-6,9,-9,10,-3,16,-7,17,-8,21});
    states[8] = new State(-4);
    states[9] = new State(-5);
    states[10] = new State(new int[]{9,11});
    states[11] = new State(new int[]{8,14,6,15},new int[]{-10,12,-9,13});
    states[12] = new State(-10);
    states[13] = new State(-11);
    states[14] = new State(-9);
    states[15] = new State(-12);
    states[16] = new State(-6);
    states[17] = new State(-7);
    states[18] = new State(new int[]{8,14,6,15},new int[]{-10,19,-9,13});
    states[19] = new State(new int[]{8,14,3,4,5,18,11,22},new int[]{-5,20,-6,9,-9,10,-3,16,-7,17,-8,21});
    states[20] = new State(-14);
    states[21] = new State(-8);
    states[22] = new State(new int[]{8,14},new int[]{-6,23,-9,10});
    states[23] = new State(new int[]{12,24});
    states[24] = new State(new int[]{8,14,6,15},new int[]{-10,25,-9,13});
    states[25] = new State(new int[]{13,26});
    states[26] = new State(new int[]{8,14,3,4,5,18,11,22},new int[]{-4,27,-5,28,-6,9,-9,10,-3,16,-7,17,-8,21});
    states[27] = new State(new int[]{10,7,4,-15});
    states[28] = new State(-3);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,2});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-4, new int[]{-5});
    rules[4] = new Rule(-4, new int[]{-4,10,-5});
    rules[5] = new Rule(-5, new int[]{-6});
    rules[6] = new Rule(-5, new int[]{-3});
    rules[7] = new Rule(-5, new int[]{-7});
    rules[8] = new Rule(-5, new int[]{-8});
    rules[9] = new Rule(-9, new int[]{8});
    rules[10] = new Rule(-6, new int[]{-9,9,-10});
    rules[11] = new Rule(-10, new int[]{-9});
    rules[12] = new Rule(-10, new int[]{6});
    rules[13] = new Rule(-3, new int[]{3,-4,4});
    rules[14] = new Rule(-7, new int[]{5,-10,-5});
    rules[15] = new Rule(-8, new int[]{11,-6,12,-10,13,-4});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
