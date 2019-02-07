################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Src/main.c \
C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Src/stm32f4xx_hal_msp.c \
C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Src/stm32f4xx_it.c 

OBJS += \
./Application/User/main.o \
./Application/User/stm32f4xx_hal_msp.o \
./Application/User/stm32f4xx_it.o 

C_DEPS += \
./Application/User/main.d \
./Application/User/stm32f4xx_hal_msp.d \
./Application/User/stm32f4xx_it.d 


# Each subdirectory must supply rules for building sources it contributes
Application/User/main.o: C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Src/main.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m4 -mthumb -mfloat-abi=hard -mfpu=fpv4-sp-d16 '-D__weak=__attribute__((weak))' '-D__packed=__attribute__((__packed__))' -DUSE_HAL_DRIVER -DSTM32F401xC -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Inc" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/STM32F4xx_HAL_Driver/Inc" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/STM32F4xx_HAL_Driver/Inc/Legacy" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/CMSIS/Device/ST/STM32F4xx/Include" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '

Application/User/stm32f4xx_hal_msp.o: C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Src/stm32f4xx_hal_msp.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m4 -mthumb -mfloat-abi=hard -mfpu=fpv4-sp-d16 '-D__weak=__attribute__((weak))' '-D__packed=__attribute__((__packed__))' -DUSE_HAL_DRIVER -DSTM32F401xC -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Inc" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/STM32F4xx_HAL_Driver/Inc" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/STM32F4xx_HAL_Driver/Inc/Legacy" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/CMSIS/Device/ST/STM32F4xx/Include" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '

Application/User/stm32f4xx_it.o: C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Src/stm32f4xx_it.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m4 -mthumb -mfloat-abi=hard -mfpu=fpv4-sp-d16 '-D__weak=__attribute__((weak))' '-D__packed=__attribute__((__packed__))' -DUSE_HAL_DRIVER -DSTM32F401xC -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Inc" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/STM32F4xx_HAL_Driver/Inc" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/STM32F4xx_HAL_Driver/Inc/Legacy" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/CMSIS/Device/ST/STM32F4xx/Include" -I"C:/Users/pati/Desktop/ALL_SENSORS/ALL_SENSORS/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


