// Copyright Alleyne Technology and all rights reserved

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "AuraCharacterBase.generated.h"

UCLASS(Abstract)
class GATE_API AAuraCharacterBase : public ACharacter
{
	GENERATED_BODY()

public:
	
	AAuraCharacterBase();

protected:
	
	virtual void BeginPlay() override;

};
