﻿
using System;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;



/// <summary>
/// 
/// Специализированный вариант объекта Поток для работы с данными, расположенными в оперативной памяти.
/// </summary>
[ContextClass("ПотокВПамяти", "MemoryStream")]
class MemoryStream : AutoContext<MemoryStream>
{
private bool _CanWrite
private bool _CanSeek
private bool _CanRead

public MemoryStream()
{
}


/// <summary>
/// 
/// Создает поток, в качестве нижележащего хранилища для которого используется заданный байтовый буфер. Ёмкость потока ограничена размером буфера. При выходе за границы буфера будет сгенерировано исключение.
/// Возможность записи в поток зависит от возможности изменения передаваемого буфера.
/// </summary>
///
/// <param name="Buffer">
/// Буфер, на основании которого будет создан поток. </param>

///

[ScriptConstructor]
public static IRuntimeContextInstance Constructor( IValue Buffer)
{
	return new MemoryStream();
}

/// <summary>
/// 
/// Создает поток в памяти с расширяемой емкостью. Данный вариант можно использовать для работы с достаточно большими объемами данных, т.к. данные хранятся постранично, а не в виде одного последовательного блока.
/// </summary>
///

///

[ScriptConstructor]
public static IRuntimeContextInstance Constructor()
{
	return new MemoryStream();
}

/// <summary>
/// 
/// Создает поток в памяти с заданной начальной емкостью, которая при необходимости автоматически расширяется. Данный вариант подходит для работы с достаточно большими объемами данных за счет того, что данные хранятся постранично, а не в виде одного последовательного блока.
/// </summary>
///
/// <param name="InitialCapacity">
/// Начальная емкость. </param>

///

[ScriptConstructor]
public static IRuntimeContextInstance Constructor( int InitialCapacity)
{
	return new MemoryStream();
}

/// <summary>
/// 
/// Признак доступности записи в поток.
/// </summary>
/// <value>Булево (Boolean)</value>
[ContextProperty("ДоступнаЗапись", "CanWrite")]
public bool CanWrite
{
	get { return _CanWrite; }
	
}


/// <summary>
/// 
/// Признак доступности произвольного изменения позиции чтения/записи в потоке.
/// </summary>
/// <value>Булево (Boolean)</value>
[ContextProperty("ДоступноИзменениеПозиции", "CanSeek")]
public bool CanSeek
{
	get { return _CanSeek; }
	
}


/// <summary>
/// 
/// Признак доступности чтения из потока.
/// </summary>
/// <value>Булево (Boolean)</value>
[ContextProperty("ДоступноЧтение", "CanRead")]
public bool CanRead
{
	get { return _CanRead; }
	
}


/// <summary>
/// 
/// Вызов данного метода завершает работу с потоком. При попытке вызвать любой метод объекта, кроме метода Закрыть, будет вызвано исключение. 
/// При повторном вызове данного метода никаких действий выполняться не будет.
/// Выполняемое действие зависит от используемого типа потока.
/// </summary>
///

///

///
[ContextMethod("Закрыть", "Close")]
public void Close()
{
	
}


/// <summary>
/// 
/// Возвращает экземпляр объекта ДвоичныеДанные, содержащего данные, записанные в поток.
/// </summary>
///

///
/// <returns name="BinaryData">
/// Значение содержит двоичные данные, которые считываются из файла. Значение может быть сохранено в ХранилищеЗначения.
/// Хранимые данные могут быть записаны в файл.</returns>

///
[ContextMethod("ЗакрытьИПолучитьДвоичныеДанные", "CloseAndGetBinaryData")]
public IValue CloseAndGetBinaryData()
{
	 return null;
}


/// <summary>
/// 
/// Записывает в поток заданное количество байтов из буфера по заданному смещению. Если в буфере меньше данных, чем требуется записать, вызывается исключение о недостаточном количестве данных в буфере.
/// Запись в поток возможна только, если поток поддерживает запись. В противном случае при вызове метода будет вызвано исключение.
/// </summary>
///
/// <param name="Buffer">
/// Буфер, из которого выбираются данные для записи. </param>
/// <param name="PositionInBuffer">
/// Позиция в буфере, начиная с которой данные будут получены для записи в поток. </param>
/// <param name="Number">
/// Количество байт, которые требуется записать. </param>

///

///
[ContextMethod("Записать", "Write")]
public void Write( IValue Buffer, int PositionInBuffer, int Number)
{
	
}


/// <summary>
/// 
/// Копирует данные из текущего потока в другой поток.
/// </summary>
///
/// <param name="TargetStream">
/// Поток, в который будет выполняться копирование. </param>
/// <param name="BufferSize">
/// Размер буфера, используемого при копировании.
/// Если параметр не задан, то система подбирает размер буфера автоматически. </param>

///

///
[ContextMethod("КопироватьВ", "CopyTo")]
public void CopyTo( IValue TargetStream, int BufferSize = null)
{
	
}


/// <summary>
/// 
/// Вызывает начало закрытие потока. Выполняемое действие зависит от конкретного типа потока.
/// Является асинхронным вариантом метода Закрыть.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>

///

///
[ContextMethod("НачатьЗакрытие", "BeginClose")]
public void BeginClose( IValue NotifyDescription)
{
	
}


/// <summary>
/// 
/// Начинает запись в поток заданного количества байтов из буфера по заданному смещению.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения записи потока со следующими параметрами:
/// 
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>
/// <param name="Buffer">
/// Буфер, данные которого получаются для записи. </param>
/// <param name="PositionInBuffer">
/// Позиция в буфере, начиная с которой требуется получить данные для записи в поток. </param>
/// <param name="Count">
/// Количество байт, которые требуется записать. </param>

///

///
[ContextMethod("НачатьЗапись", "BeginWrite")]
public void BeginWrite( IValue NotifyDescription, IValue Buffer, int PositionInBuffer, int Count)
{
	
}


/// <summary>
/// 
/// Начинает копирование данных из текущего потока в другой поток. Если размер буфера не задан, он будет установлен автоматически.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>
/// <param name="TargetStream">
/// Поток, в который будет производиться копирование. </param>
/// <param name="BufferSize">
/// Размер буфера, используемого при копировании.
/// Если не задан, размер буфера будет установлен автоматически. </param>

///

///
[ContextMethod("НачатьКопированиеВ", "BeginCopyTo")]
public void BeginCopyTo( IValue NotifyDescription, IValue TargetStream, int BufferSize = null)
{
	
}


/// <summary>
/// 
/// Начинает сдвиг текущей позиции потока на заданное количество байтов относительно начальной позиции. Если указано отрицательное смещение, позиция сдвигается в направлении к началу потока.
/// Если изменение позиции недоступно (ДоступноИзменениеПозиции установлено в Ложь), будет сгенерировано исключение.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>
/// <param name="Offset">
/// Количество байтов, на которое нужно передвинуть позицию в потоке. </param>
/// <param name="InitialPosition">
/// Начальная позиция, от которой отсчитывается смещение. </param>

///

///
[ContextMethod("НачатьПереход", "BeginSeek")]
public void BeginSeek( IValue NotifyDescription, int Offset, IValue InitialPosition = null)
{
	
}


/// <summary>
/// 
/// Возвращает размер данных в байтах.
/// Если свойство ДоступноИзменениеПозиции установлено в значение Ложь, то при вызове данного метода будет сгенерировано исключение.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <Результат> - тип Число. Размер данных в байтах.
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>

///

///
[ContextMethod("НачатьПолучениеРазмера", "BeginGetSize")]
public void BeginGetSize( IValue NotifyDescription = null)
{
	
}


/// <summary>
/// 
/// Начинает сбрасывать все промежуточные буферы и производить запись всех незаписанных данных в целевое устройство.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>

///

///
[ContextMethod("НачатьСбросБуферов", "BeginFlush")]
public void BeginFlush( IValue NotifyDescription)
{
	
}


/// <summary>
/// 
/// Начинает установку размера потока.
/// Если текущий размер превышает заданный, поток будет сокращен до заданного размера, а информация, превышающая заданный размер, будет потеряна.
/// Если текущий размер потока меньше заданного, то содержимое потока между старым и новым размером не определено.
/// </summary>
///
/// <param name="ОписаниеОповещения">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>
/// <param name="Размер">
/// Устанавливаемый размер потока. </param>

///

///
[ContextMethod("НачатьУстановкуРазмера", "BeginSetSize")]
public void BeginSetSize( IValue ОписаниеОповещения, int Размер)
{
	
}


/// <summary>
/// 
/// Начинает чтение заданного количества байтов в указанный буфер по указанному смещению. Текущая позиция смещается вперед на фактическое количество прочитанных байтов.
/// Чтение из потока возможно только, если поток поддерживает чтение. В противном случае, будет вызвано исключение.
/// </summary>
///
/// <param name="NotifyDescription">
/// Содержит описание процедуры, которая будет вызвана после завершения работы метода со следующими параметрами:
/// 
///  - <Количество> - тип Число. Результат выполнения метода.
///  - <ДополнительныеПараметры> - значение, которое было указано при создании объекта ОписаниеОповещения. </param>
/// <param name="Buffer">
/// Буфер, в который выполняется чтение. </param>
/// <param name="PositionInBuffer">
/// Позиция в целевом буфере, начиная с которой требуется записывать данные из потока. </param>
/// <param name="Number">
/// Количество байтов, которые требуется записать в целевой буфер. </param>

///

///
[ContextMethod("НачатьЧтение", "BeginRead")]
public void BeginRead( IValue NotifyDescription, IValue Buffer, int PositionInBuffer, int Number)
{
	
}


/// <summary>
/// 
/// Сдвигает текущую позицию потока на заданное количество байтов относительно начальной позиции. Если указано отрицательное смещение, позиция сдвигается в направлении к началу потока.
/// Если изменение позиции недоступно (ДоступноИзменениеПозиции установлено в Ложь), будет сгенерировано исключение.
/// </summary>
///
/// <param name="Offset">
/// Количество байтов, на которое нужно передвинуть позицию в потоке. </param>
/// <param name="InitialPosition">
/// Начальная позиция, от которой отсчитывается смещение. </param>

///
/// <returns name="Number">
/// Числовым типом может быть представлено любое десятичное число. Над данными числового типа определены основные арифметические операции: сложение, вычитание, умножение и деление. Максимально допустимая разрядность числа 38 знаков.</returns>

///
[ContextMethod("Перейти", "Seek")]
public int Seek( int Offset, IValue InitialPosition = null)
{
	 return null;
}


/// <summary>
/// 
/// Возвращает поток, который разделяет данные и текущую позицию с данным потоком, но не разрешает запись.
/// </summary>
///

///
/// <returns name="Stream">
/// Представляет собой поток данных, который можно последовательно читать и/или в который можно последовательно писать. 
/// Экземпляры объектов данного типа можно получить с помощью различных методов других объектов.</returns>

///
[ContextMethod("ПолучитьПотокТолькоДляЧтения", "GetReadonlyStream")]
public IValue GetReadonlyStream()
{
	 return null;
}


/// <summary>
/// 
/// Выполняет чтение заданного количества байтов в указанный буфер по указанному смещению. Текущая позиция смещается вперед на фактическое количество прочитанных байтов.
/// Чтение из потока возможно только, если поток поддерживает чтение. В противном случае, будет вызвано исключение.
/// При чтении размер целевого буфера не меняется, а его содержимое перезаписывается фактически прочитанными данными. Если в буфере недостаточно места для записи прочитанных данных, происходит ошибка переполнения.
/// </summary>
///
/// <param name="Buffer">
/// Буфер, в который выполняется чтение. </param>
/// <param name="PositionInBuffer">
/// Позиция в целевом буфере, начиная с которой требуется записывать данные из потока. </param>
/// <param name="Number">
/// Количество байт, которые требуется записать в целевой буфер. </param>

///
/// <returns name="Number">
/// Числовым типом может быть представлено любое десятичное число. Над данными числового типа определены основные арифметические операции: сложение, вычитание, умножение и деление. Максимально допустимая разрядность числа 38 знаков.</returns>

///
[ContextMethod("Прочитать", "Read")]
public int Read( IValue Buffer, int PositionInBuffer, int Number)
{
	 return null;
}


/// <summary>
/// 
/// Получает размер данных в байтах.
/// </summary>
///

///
/// <returns name="Number">
/// Числовым типом может быть представлено любое десятичное число. Над данными числового типа определены основные арифметические операции: сложение, вычитание, умножение и деление. Максимально допустимая разрядность числа 38 знаков.</returns>

///
[ContextMethod("Размер", "Size")]
public int Size()
{
	 return null;
}


/// <summary>
/// 
/// Сбрасывает все промежуточные буферы и производит запись всех незаписанных данных в целевое устройство.
/// </summary>
///

///

///
[ContextMethod("СброситьБуферы", "Flush")]
public void Flush()
{
	
}


/// <summary>
/// 
/// Возвращает текущую позицию в потоке.
/// </summary>
///

///
/// <returns name="Number">
/// Числовым типом может быть представлено любое десятичное число. Над данными числового типа определены основные арифметические операции: сложение, вычитание, умножение и деление. Максимально допустимая разрядность числа 38 знаков.</returns>

///
[ContextMethod("ТекущаяПозиция", "CurrentPosition")]
public int CurrentPosition()
{
	 return null;
}


/// <summary>
/// 
/// Устанавливает размер потока.
/// Если текущий размер превышает заданный, поток будет сокращен до заданного размера, а информация, превышающая заданный размер, будет потеряна.
/// Если текущий размер потока меньше заданного, то содержимое потока между старым и новым размером не определено.
/// </summary>
///
/// <param name="Size">
/// Устанавливаемый размер потока. </param>

///

///
[ContextMethod("УстановитьРазмер", "SetSize")]
public void SetSize( int Size)
{
	
}

}