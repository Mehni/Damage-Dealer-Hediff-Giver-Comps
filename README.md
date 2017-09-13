# Damage Dealer/Hediff Giver

## Usage
Using this tool is as easy as making simple changes to the xml of your ThingDefs.

#### tickerType
A tickerType is required for both the damage dealer and hediff giver. Always include this in your code!
TickerType can be Normal ~1/60s, Rare ~4s, or Long ~33s.

##### Usage
```xml 
<tickerType>Normal</tickerType>
```
##### Example
```xml 
<ThingDefs>
    ...
    <ThingDef>
        ...
        <tickerType>Normal</tickerType>
        <!-- Damage Dealer/Hediff Giver code here -->
    </ThingDef>
</ThingDefs>
```

#### Damage Dealer Comp
A comp for dealing damage to nearby pawns, can be used in conjunction with Hediff Giver.

##### Usage
```xml 
<li Class="HediffDamageComps.CompProperties_DamageDealer">
	<compClass>HediffDamageComps.CompDamageDealer</compClass>
	<damageAmount><!-- Number --></damageAmount>
	<damageDef><!-- Defs/DamageDefs/Damages_*/DamageDef --></damageDef>
	<affectInteractionCell><!-- Boolean --></affectInteractionCell>
	<affectAdjacentCells><!-- Boolean --></affectAdjacentCells>
	<affectOwnCell><!-- Boolean --></affectOwnCell>
	<damagesSelf><!-- Boolean --></damagesSelf>
	<ticksBetweenDamage><!-- Number, ~60 Ticks/Second --></ticksBetweenDamage>
</li>
```

##### Example
```xml 
<ThingDefs>
    ...
    <ThingDef>
        ...
        <tickerType>Normal</tickerType>
        <comps>
            <li Class="HediffDamageComps.CompProperties_DamageDealer">
                <compClass>HediffDamageComps.CompDamageDealer</compClass>
                <damageAmount>1</damageAmount>
                <damageDef>Crush</damageDef>
                <affectInteractionCell>true</affectInteractionCell>
                <affectAdjacentCells>false</affectAdjacentCells>
		<affectOwnCell>true</affectOwnCell>
                <damagesSelf>false</damagesSelf>
                <ticksBetweenDamage>2000</ticksBetweenDamage>
            </li>
        </comps>
    </ThingDef>
</ThingDefs>
```

#### Hediff Giver Comp
A comp for giving an hediff to nearby pawns, can be used in conjunction with damage dealer.

##### Usage
```xml 
<li Class="HediffDamageComps.CompProperties_HediffGiver">
	<compClass>HediffDamageComps.CompHediffGiver</compClass>
	<hediffDef><!-- Defs/HediffDefs/Hediffs_*/HediffDef --></hediffDef>
	<affectInteractionCell><!-- Boolean --></affectInteractionCell>
	<affectAdjacentCells><!-- Boolean --></affectAdjacentCells>
	<affectOwnCell><!-- Boolean --></affectOwnCell>
	<affectsSelf><!-- Boolean --></affectsSelf>
	<ticksBetweenEffect><!-- Number --></ticksBetweenEffect>
</li>
```

##### Example
```xml 
<ThingDefs>
    ...
    <ThingDef>
        ...
        <tickerType>Normal</tickerType>
        <comps>
	        <li Class="HediffDamageComps.CompProperties_HediffGiver">
		        <compClass>HediffDamageComps.CompHediffGiver</compClass>
		        <hediffDef>Carcinoma</hediffDef>
		        <affectInteractionCell>true</affectInteractionCell>
		        <affectAdjacentCells>true</affectAdjacentCells>
			<affectOwnCell>true</affectOwnCell>
		        <affectsSelf>false</affectsSelf>
		        <ticksBetweenEffect>80000</ticksBetweenEffect>
	        </li>
        </comps>
    </ThingDef>
</ThingDefs>
```

##### Combined Example
```xml 
<ThingDefs>
    ...
    <ThingDef>
        ...
        <tickerType>Normal</tickerType>
        <comps>
		<li Class="HediffDamageComps.CompProperties_HediffGiver">
			<compClass>HediffDamageComps.CompHediffGiver</compClass>
			<hediffDef>Carcinoma</hediffDef>
			<affectInteractionCell>true</affectInteractionCell>
			<affectOwnCell>true</affectOwnCell>
			<affectAdjacentCells>true</affectAdjacentCells>
			<affectsSelf>false</affectsSelf>
			<ticksBetweenEffect>80000</ticksBetweenEffect>
		</li>
		<li Class="HediffDamageComps.CompProperties_DamageDealer">
			<compClass>HediffDamageComps.CompDamageDealer</compClass>
			<damageAmount>1</damageAmount>
			<damageDef>Crush</damageDef>
			<affectInteractionCell>true</affectInteractionCell>
			<affectAdjacentCells>false</affectAdjacentCells>
			<affectOwnCell>true</affectOwnCell>
			<damagesSelf>false</damagesSelf>
			<ticksBetweenDamage>2000</ticksBetweenDamage>
		</li>
        </comps>
    </ThingDef>
</ThingDefs>
```

## Limitations/Bugs:
Cannot be applied to plants (specifically, plants cannot have the necessary ticker)

Currently there is a check to see if the item has a power comp, and if power is on. Manually remove that check and recompile if you want items to emit damage/hediffs despite power status.
